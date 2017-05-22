using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using System.Xml.XPath;
using CommandLine;
using HwcBootstrapper.ConfigTemplates;
using HWCServer;
using SimpleImpersonation;

namespace HwcBootstrapper
{
    class Program
    {
        static bool ConsoleEventCallback(CtrlEvent eventType)
        {
            Shutdown();
            return true;
        }

        private static Options _options;

        static int Main(string[] args)
        {
            SystemEvents.SetConsoleEventHandler(ConsoleEventCallback);
            try
            {
                _options = LoadOptions(args);

                var appConfigTemplate = new ApplicationHostConfig {Model = _options};
                var appConfigText = appConfigTemplate.TransformText();
                ValidateRequiredDllDependencies(appConfigText);
                var webConfigText = new WebConfig() {Model = _options}.TransformText();
                var aspNetText = new AspNetConfig().TransformText();

                Directory.CreateDirectory(_options.TempDirectory);
                Directory.CreateDirectory(_options.ConfigDirectory);
                File.WriteAllText(_options.ApplicationHostConfigPath, appConfigText);
                File.WriteAllText(_options.WebConfigPath, webConfigText);
                File.WriteAllText(_options.AspnetConfigPath, aspNetText);



                var impersonationRequired = !string.IsNullOrEmpty(_options.User);
                IDisposable impresonationContext;
                if (impersonationRequired)
                {
                    string userName = _options.User;
                    string domain = string.Empty;
                    var match = Regex.Match(_options.User, @"^(?<domain>\w+)\\(?<user>\w+)$"); // parse out domain from format DOMAIN\Username

                    if (match.Success)
                    {
                        userName = match.Groups["user"].Value;
                        domain = match.Groups["domain"].Value;
                    }

                    impresonationContext = Impersonation.LogonUser(domain, userName, _options.Password, LogonType.Network);
                }
                else
                {
                    impresonationContext = new DummyDisposable();
                }
                using (impresonationContext)
                {
                    try
                    {
                        HostableWebCore.Activate(_options.ApplicationHostConfigPath, _options.WebConfigPath, _options.ApplicationInstanceId);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.Error.WriteLine("Access denied starting hostable web core. Start the application as administrator");
                        Console.WriteLine("===========================");
                        throw;
                    }
                }


                Console.WriteLine($"Server ID {_options.ApplicationInstanceId} started");
                Console.WriteLine("PRESS Enter to shutdown");

                Console.ReadLine();
            }

            catch (ValidationException ve)
            {
                Console.Error.WriteLine(ve.Message);
                return 1;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return 1;
            }
            finally
            {
                Shutdown();
            }
            
            return 0;
        }

        private static void Shutdown()
        {

            try
            {
                HostableWebCore.Shutdown(true);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Hostable webcore didn't shut down cleanly:");
                Console.Error.WriteLine(ex);
            }
            
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Directory.Delete(_options.TempDirectory);
                }
                catch (UnauthorizedAccessException) // just make sure all locks are released
                {
                    Thread.Sleep(500);
                }
            }
        }

        private class DummyDisposable : IDisposable
        {
            public void Dispose()
            {
                
            }
        }
        public static Options LoadOptions(string[] args)
        {
            var options = new Options();
            int port;
            if (int.TryParse(Environment.GetEnvironmentVariable("PORT"), out port))
            {
                options.Port = port;
            }
            var isValid = Parser.Default.ParseArgumentsStrict(args, options);
            if (!isValid)
            {
                throw new ValidationException("bad args!");
            }
            var userProfileFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            options.ApplicationInstanceId = Guid.NewGuid().ToString();
            options.TempDirectory = Path.Combine(userProfileFolder, $"tmp{options.ApplicationInstanceId}");
            var configDirectory = Path.Combine(options.TempDirectory, "config");
            options.ApplicationHostConfigPath = Path.Combine(configDirectory, "ApplicationHost.config");
            options.WebConfigPath = Path.Combine(configDirectory, "Web.config");
            options.AspnetConfigPath = Path.Combine(configDirectory, "AspNet.config");
            return options;
        }
        public static void ValidateRequiredDllDependencies(string applicationHostConfigText)
        {
            var doc = XDocument.Parse(applicationHostConfigText);

            var missingDlls = doc.XPathSelectElements("//configuration/system.webServer/globalModules/add")
                .Select(x => Environment.ExpandEnvironmentVariables(x.Attribute("image").Value))
                .Where(x => !File.Exists(x))
                .ToList();
            if (missingDlls.Any())
            {
                throw new ValidationException($"Missing required ddls:\n{string.Join("\n", missingDlls)}");
            }
        }
    }
}
