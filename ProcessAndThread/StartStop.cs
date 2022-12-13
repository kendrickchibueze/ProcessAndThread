using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessAndThread
{
    internal class StartStop
    {

        public static void StartingAndStoppingProcessProgrammatically()
        {
            Process proc = null;

            //start a process
            try
            {
                
                proc = Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe ", "www.twitter.com");
                Console.WriteLine(proc?.ProcessName);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }


            //kill a process
            Console.WriteLine("--->Hit enter to kill a process....", proc.ProcessName);
            Console.ReadLine();

            //kill all of the chrome processes

            try
            {
                foreach (var p in Process.GetProcessesByName(proc?.ProcessName))
                {
                    p.Kill(true);
                }
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine( ex.Message);

            }
        }
    }
}
