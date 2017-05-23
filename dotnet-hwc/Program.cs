using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using System.Xml.XPath;
using CommandLine;
using HwcBootstrapper.ConfigTemplates;
using SimpleImpersonation;

namespace HwcBootstrapper
{
    class Program
    {
        private static Options _options;

        private static readonly ManualResetEvent _exitWaitHandle = new ManualResetEvent(false);

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
                IDisposable impresonationContext = null;
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

                    impresonationContext = Impersonation.LogonUser(domain, userName, _options.Password, LogonType.NewCredentials);
                }
                try
                {
                    HostableWebCore.Activate(_options.ApplicationHostConfigPath, _options.WebConfigPath, _options.ApplicationInstanceId);
                }
                catch (UnauthorizedAccessException)
                {
                    Console.Error.WriteLine("Access denied starting hostable web core. Start the application as administrator");
                    Console.WriteLine("===========================");
                    throw;
                }
                finally
                {
                    impresonationContext?.Dispose();
                }

                Console.WriteLine($"Server ID {_options.ApplicationInstanceId} started");
                Console.WriteLine("PRESS Enter to shutdown");
                // we gonna read on different thread here because Console.ReadLine is not the only way the program can end
                // we're also listening to the system events where the app is ordered to shutdown. exitWaitHandle is used to
                // hook up both of these events
                new Thread(() =>
                    {
                        Console.ReadLine();
                        _exitWaitHandle.Set();
                    }).Start();
                _exitWaitHandle.WaitOne();
                return 0;
            }

            catch (ValidationException ve)
            {
                Console.Error.WriteLine(ve.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            finally
            {
                Shutdown();
            }

            return 1;
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
            if (Directory.Exists(_options.TempDirectory))
            {
                for (var i = 0; i < 5; i++)
                {
                    try
                    {
                        Directory.Delete(_options.TempDirectory, true);
                        break;
                    }
                    catch (UnauthorizedAccessException) // just make sure all locks are released, cuz hwc may not shutdown instantly
                    {
                        Thread.Sleep(500);
                    }
                }
            }
        }

        static bool ConsoleEventCallback(CtrlEvent eventType)
        {
            _exitWaitHandle.Set();
            return true;
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
