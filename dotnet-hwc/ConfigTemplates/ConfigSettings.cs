using System;

namespace HwcBootstrapper.ConfigTemplates
{
    public class ConfigSettings
    {
        public int Port { get; set; } = 8080;
        public string AspnetConfigPath { get; set; } = string.Empty;
        public string TempDirectory { get; set; } = string.Empty;
        public string RootPath { get; set; } = string.Empty;
    }
}