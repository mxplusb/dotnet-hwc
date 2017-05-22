using System;
using System.IO;
using System.Runtime.InteropServices;

namespace HWCServer {

//    internal class WebServer : IDisposable {
//
//        private string _appHostConfigPath;
//        private string _rootWebConfigPath;
//
//        public WebServer(string physicalPath, int port, int siteId) {
//            string appPoolName = "AppPool" + port.ToString();
//            _appHostConfigPath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName() + ".config");
//            _rootWebConfigPath = Environment.ExpandEnvironmentVariables(@"%windir%\Microsoft.Net\Framework\v2.0.50727\config\web.config");
//
//            string appHostContent = Resources.AppHostAspNet;
//            //string appHostContent = Resources.AppHostStaticFiles;
//
//            File.WriteAllText(_appHostConfigPath,
//                String.Format(appHostContent,
//                              port,
//                              physicalPath,
//                              @"%windir%\Microsoft.NET\Framework\v2.0.50727",
//                              siteId,
//                              appPoolName));
//        }
//
//        ~WebServer() {
//            Dispose(false);
//        }
//
//        public void Dispose() {
//            Dispose(true);
//        }
//
//        private void Dispose(bool disposing) {
//            if (disposing) {
//                GC.SuppressFinalize(this);
//            }
//
//            Stop();
//        }
//
//        public void Start() {
//            if (!HostableWebCore.IsActivated) {
//                HostableWebCore.Activate(_appHostConfigPath, _rootWebConfigPath, Guid.NewGuid().ToString());
//            }
//        }
//
//        public void Stop() {
//            if (HostableWebCore.IsActivated) {
//                HostableWebCore.Shutdown(false);
//            }
//        }

        #region Hostable WebCore
        internal static class HostableWebCore {

            private static bool _isActivated;


            private delegate int FnWebCoreActivate([In, MarshalAs(UnmanagedType.LPWStr)]string appHostConfig, [In, MarshalAs(UnmanagedType.LPWStr)]string rootWebConfig, [In, MarshalAs(UnmanagedType.LPWStr)]string instanceName);
            private delegate int FnWebCoreShutdown(bool immediate);

            private static FnWebCoreActivate WebCoreActivate;
            private static FnWebCoreShutdown WebCoreShutdown;

            static HostableWebCore() {
                // Load the library and get the function pointers for the WebCore entry points
                const string HWCPath = @"%windir%\system32\inetsrv\hwebcore.dll";
                IntPtr hwc = NativeMethods.LoadLibrary(Environment.ExpandEnvironmentVariables(HWCPath));

                IntPtr procaddr = NativeMethods.GetProcAddress(hwc, "WebCoreActivate");
                WebCoreActivate = (FnWebCoreActivate)Marshal.GetDelegateForFunctionPointer(procaddr, typeof(FnWebCoreActivate));

                procaddr = NativeMethods.GetProcAddress(hwc, "WebCoreShutdown");
                WebCoreShutdown = (FnWebCoreShutdown)Marshal.GetDelegateForFunctionPointer(procaddr, typeof(FnWebCoreShutdown));
            }

            /// <summary>
            /// Specifies if Hostable WebCore ha been activated
            /// </summary>
            public static bool IsActivated {
                get {
                    return _isActivated;
                }
            }

            /// <summary>
            /// Activate the HWC
            /// </summary>
            /// <param name="appHostConfig">Path to ApplicationHost.config to use</param>
            /// <param name="rootWebConfig">Path to the Root Web.config to use</param>
            /// <param name="instanceName">Name for this instance</param>
            public static void Activate(string appHostConfig, string rootWebConfig, string instanceName) {
                int result = WebCoreActivate(appHostConfig, rootWebConfig, instanceName);
                if (result != 0) {
                    Marshal.ThrowExceptionForHR(result);
                }

                _isActivated = true;
            }

            /// <summary>
            /// Shutdown HWC
            /// </summary>
            public static void Shutdown(bool immediate) {
                if (_isActivated) {
                    WebCoreShutdown(immediate);
                    _isActivated = false;
                }
            }

            private static class NativeMethods {
                [DllImport("kernel32.dll")]
                internal static extern IntPtr LoadLibrary(String dllname);

                [DllImport("kernel32.dll")]
                internal static extern IntPtr GetProcAddress(IntPtr hModule, String procname);
            }
        }
        #endregion
}
