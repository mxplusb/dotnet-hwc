using System;
using System.IO;
using CommandLine;

namespace HwcBootstrapper
{
    public class Options
    {
        [Option("appRootPath", DefaultValue = ".", HelpText = "app web root path", Required = false)]
        public string AppRootPath { get; set; } = Environment.CurrentDirectory;

        [Option("port", HelpText = "port for the application to listen with", Required = false)]
        public int Port { get; set; } = 8080;

        [Option("user", DefaultValue = "", HelpText = "windows username to run application to run under (if user part of domain, use DOMAIN\\Username)", Required = false)]
        public string User { get; set; } 

        [Option("password", DefaultValue = "", HelpText = "windows password to run application to run under", Required = false)]
        public string Password { get; set; }

        public string AspnetConfigPath { get; set; } = string.Empty;
        public string WebConfigPath { get; set; } = string.Empty;
        public string TempDirectory { get; set; } = string.Empty;
        public string ConfigDirectory => Path.Combine(TempDirectory, "config");
        public string ApplicationHostConfigPath { get; set; } = string.Empty;
        public string ApplicationInstanceId { get; set; } = Guid.NewGuid().ToString();
    }
}