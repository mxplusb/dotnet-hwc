using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using CommandLine;
using HwcBootstrapper.ConfigTemplates;

namespace HwcBootstrapper
{
    class Program
    {

        static int Main(string[] args)
        {
            var options = new Options();
            try
            {
                var isValid = Parser.Default.ParseArgumentsStrict(args, options);
                if (!isValid)
                {
                    throw new ValidationException("bad args!");
                }
                var appConfigTemplate = new ApplicationHostConfig();
                //todo: Merge Config settings and Option class
                appConfigTemplate.Model = new ConfigSettings();
                var appConfigText = appConfigTemplate.TransformText();

                ValidateRequiredDependencies(appConfigText);

                string rootPath = Path.GetFullPath(options.AppRootPath);
                string uuid = Guid.NewGuid().ToString();
                string userProfile = "";

                // I don't think we actually need this, it should exist as you literally cannot
                // do anything not as a user.
                try
                {
                    userProfile = Environment.GetEnvironmentVariable("USERPROFILE");
                    if (userProfile == "")
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("%USERPROFILE% is missing!");
                    Environment.Exit(1);
                }

                string tempPath = Path.GetPathRoot(Path.Combine(userProfile, uuid, "tmp"));

                try
                {
                    Directory.CreateDirectory(tempPath);
                }
                catch (IOException io)
                {
                    Console.WriteLine("cannot create temp directory for {0}: {1}", options.AppRootPath, io);
                }

                // hwc new config logic


            }

            catch (ValidationException ve)
            {
                Console.Error.WriteLine(ve.Message);
                return 1;
            }
            return 0;
        }
        public static void ValidateRequiredDependencies(string applicationHostConfigText)
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

    class Options
    {
        [Option("appRootPath", DefaultValue = ".", HelpText = "app web root path", Required = false)]
        public string AppRootPath { get; set; } = Environment.CurrentDirectory;

        [Option("port", DefaultValue = 0, HelpText = "port for the application to listen with", Required = false)]
        public int Port { get; set; } = 8080;

        [Option("user", DefaultValue = "", HelpText = "windows username to run application to run under", Required = false)]
        public string User { get; set; } 

        [Option("password", DefaultValue = "", HelpText = "windows password to run application to run under", Required = false)]
        public string Password { get; set; }
    }
}
