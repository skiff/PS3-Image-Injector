using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PS3_Image_Injector {
    static class Program {
        static int cnt;
        static IDictionary<string, Assembly> assemblyDictionary;
        [STAThread]
        static void Main() {
            AppDomain.CurrentDomain.AssemblyResolve += OnResolveAssembly;
            if (cnt != 1) {
                cnt = 1;
                Assembly executingAssembly = Assembly.GetExecutingAssembly();
                string[] resources = executingAssembly.GetManifestResourceNames();
                foreach (string resource in resources) {
                    if (resource.EndsWith(".dll")) {
                        using (Stream stream = executingAssembly.GetManifestResourceStream(resource)) {
                            if (stream == null)
                                continue;

                            byte[] assemblyRawBytes = new byte[stream.Length];
                            stream.Read(assemblyRawBytes, 0, assemblyRawBytes.Length);
                            try {
                                assemblyDictionary.Add(resource, Assembly.Load(assemblyRawBytes));
                            }
                            catch {

                            }
                        }
                    }
                }
                Program.Main();
            }
            if (cnt == 1) {
                cnt = 2;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }

        private static Assembly OnResolveAssembly(object sender, ResolveEventArgs e) {
            var thisAssembly = Assembly.GetExecutingAssembly();

            // Get the Name of the AssemblyFile
            var assemblyName = new AssemblyName(e.Name);
            var dllName = assemblyName.Name + ".dll";

            // Load from Embedded Resources
            var resources = thisAssembly.GetManifestResourceNames().Where(s => s.EndsWith(dllName));
            if (resources.Any()) {
                // 99% of cases will only have one matching item, but if you don't,
                // you will have to change the logic to handle those cases.
                var resourceName = resources.First();
                using (var stream = thisAssembly.GetManifestResourceStream(resourceName)) {
                    if (stream == null) return null;
                    var block = new byte[stream.Length];

                    // Safely try to load the assembly.
                    try {
                        stream.Read(block, 0, block.Length);
                        return Assembly.Load(block);
                    }
                    catch (IOException) {
                        return null;
                    }
                    catch (BadImageFormatException) {
                        return null;
                    }
                }
            }

            // in the case the resource doesn't exist, return null.
            return null;
        }
    }
}
