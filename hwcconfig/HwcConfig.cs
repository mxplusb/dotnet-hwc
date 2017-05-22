using System;
using System.IO;

namespace hwcconfig {
    /// <summary>
    /// HwcConfig manages all the configs related to the initial HWC instantiation.
    /// </summary>
    public class HwcConfig {
        public int Port;
        public string Instance;
        public string RootPath;
        public string TempDirectory;
        public string AspnetConfigPath;
        public string WebConfigPath;
        public string ApplicationHostConfigPath;

        public HwcConfig New(int port, string rootPath, string tempPath, string uuid) {
            HwcConfig hConf = new HwcConfig() {
                Port = port,
                RootPath = rootPath,
                TempDirectory = tempPath,
                Instance = uuid
            };

            string localDest = Path.Combine(hConf.TempDirectory, "config");

            try {
                Directory.CreateDirectory(localDest);
            } catch (IOException io) {
                Console.WriteLine("Cannot create HWC config folder at {0}: {1}", localDest, io);
                Environment.Exit(1);
            }

            hConf.ApplicationHostConfigPath = Path.Combine(localDest, "ApplicationHost.config");
            hConf.AspnetConfigPath = Path.Combine(localDest, "Aspnet.config");
            hConf.WebConfigPath = Path.Combine(localDest, "Web.config");

            // TODO have to write the generators for the ApplicationHost configs,
            // ASP.NET configs, and Web configs. the XML template from `hwc.exe`
            // has been converted into a pure classful XML structure with it's 
            // own parser. I haven't tested it, but it compiles, so that's a plus!

            // REMINDER: write some fucking tests, I have no idea how to write tests, haha. this
            // is more my reminder to myself than a TODO item.

            // TODO: might wanna look at moving the XML classes to a separate namespace
            // so IntelliSense doesn't give you the autocomplete options so often...

            return hConf;
        }


    }
}
