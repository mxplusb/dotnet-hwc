﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Security;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using System.Xml.XPath;
using CommandLine;
using HwcBootstrapper.ConfigTemplates;
using JobManagement;
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
            IDisposable impresonationContext = null;
            try
            {
                _options = LoadOptions(args);
                var impersonationRequired = !string.IsNullOrEmpty(_options.User);
                if (impersonationRequired)
                {
                    Impersonate();
                }
                else
                {




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

                    Console.WriteLine("Activating HWC with following settings:");

//                if (impersonationRequired)
//                {
//                    string userName = _options.User;
//                    string domain = null;
//                    var match = Regex.Match(_options.User, @"^(?<domain>\w+)\\(?<user>\w+)$"); // parse out domain from format DOMAIN\Username
//
//                    if (match.Success)
//                    {
//                        userName = match.Groups["user"].Value;
//                        domain = match.Groups["domain"].Value;
//                    }
//                    Console.WriteLine($"Impersonation user {userName} for domain {domain}");
//                    impresonationContext = Impersonation.LogonUser(domain, userName, _options.Password, LogonType.Service);
//                    Console.WriteLine(WindowsIdentity.GetCurrent().Name);
//                }
                    try
                    {

                        Console.WriteLine($"ApplicationHost.config: {_options.ApplicationHostConfigPath}");
                        Console.WriteLine($"Web.config: {_options.WebConfigPath}");
//                        var process = Process.Start("cmd");
//                        var job = new Job();
//                        job.AddProcess(process.Handle);
                        HostableWebCore.Activate(_options.ApplicationHostConfigPath, _options.WebConfigPath, _options.ApplicationInstanceId);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.Error.WriteLine("Access denied starting hostable web core. Start the application as administrator");
                        Console.WriteLine("===========================");
                        throw;
                    }


                    Console.WriteLine($"Server ID {_options.ApplicationInstanceId} started");
                    Console.WriteLine("PRESS Enter to shutdown");
                    // we gonna read on different thread here because Console.ReadLine is not the only way the program can end
                    // we're also listening to the system events where the app is ordered to shutdown. exitWaitHandle is used to
                    // hook up both of these events
                    
                }
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
//                impresonationContext?.Dispose();
            }
            Console.ReadLine();
            return 1;
        }

        private static void Impersonate()
        {
            var exeName = Process.GetCurrentProcess().MainModule.FileName;
            var args = $"--appRootPath={_options.AppRootPath} --port={_options.Port}";
            var processStartInfo = new ProcessStartInfo(exeName, args)
            {
                Domain = _options.Domain,
                UserName = _options.UsernameWithoutDomain,
                Password = _options.Password.ToSecureString(),
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                CreateNoWindow = true,
                Verb="runas"
            };
            _childProcess = Process.Start(processStartInfo);
            if(_childProcess == null)
                throw new Exception("Impersonation of child process failed");
            _childProcess.BeginOutputReadLine();
            _childProcess.BeginErrorReadLine();
            _childProcess.OutputDataReceived += (sender, eventArgs) => Console.WriteLine(eventArgs.Data);
            _childProcess.ErrorDataReceived += (sender, eventArgs) => Console.Error.WriteLine(eventArgs.Data);
            
            var job = new Job();
            job.AddProcess(_childProcess.Handle);
        }

        private static Process _childProcess;
        private static void Shutdown()
        {
            if (_childProcess != null)
            {
                _childProcess.StandardInput.Write("\n");
                _childProcess.WaitForExit(5000);
            }
            else
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
            options.User = Environment.GetEnvironmentVariable("SERVICE_USERNAME");
            options.Password = Environment.GetEnvironmentVariable("SERVICE_PASSWORD");

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
