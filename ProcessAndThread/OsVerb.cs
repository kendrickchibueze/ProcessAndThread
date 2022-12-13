using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessAndThread
{
    internal class OsVerb
    {

        public static void UsingProcessStartInfoWithOsVerbs()
        {
            Process proc = null;

            //start a process using process start info

            try
            {
                int i = 0;
                ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");   

                foreach (var verb in startInfo.Verbs)
                {
                    Console.WriteLine($"{i++}.{verb}");
                }

                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.Verb = "Open";
                startInfo.UseShellExecute = true;
               proc = Process.Start(startInfo);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //kill a process
            Console.WriteLine("-->Hit enter to kill {0} ...", proc.ProcessName);
            Console.ReadLine();


            //kill all of the chrome processes
            try
            {
                foreach(var p in Process.GetProcessesByName(proc?.ProcessName))
                {
                    p.Kill(true);
                }
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
