using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessAndThread
{
    internal class ThreadProcess
    {
        public static void EnumeratingProcess()
        {
            var runningProcesses = from proc in Process.GetProcesses()
                                   orderby proc.Id
                                   select proc;


            foreach(var p in runningProcesses)
            {
                string info = $"->PID:{p.Id}\tName:{p.ProcessName}";
                Console.WriteLine(info);
            }

            Console.WriteLine("**************************************************************");
        }

        //Note that dormains, assemblies and project are the same and can be used interchangeably
        //your chrome is a process, when you expand it, you find subprocesses called Modules
        //A module is an executable hosted by a  process. The  process is a dormain in this context which is part of a primary thread
        //Threads are what your process spin up(children of a process are either threads or modules)
        //An appdormain contains different assemblies
        //For our process to work, it must spin up a primary thread ie no primary thread, no process
        //A process in an appDormain contains several assemblies

        //A process which has another thing in addition to the  primary thread is a multithread






        public static void GetSpecificProcessAndItsThread()
        {
            Process theProc = null;


            try
            {
                theProc = Process.GetProcessById(Process.GetCurrentProcess().Id);
                Console.WriteLine(theProc?.ProcessName);

                Console.WriteLine("Here are the threads used by:{0}", theProc.ProcessName);

                ProcessThreadCollection theThreads = theProc.Threads;


                foreach (ProcessThread pt in theThreads)
                {
                    string info = $"-->Thread ID: {pt.Id}\t start Time:{pt.StartTime.ToShortTimeString()}\tPriority:{pt.PriorityLevel}";


                    Console.WriteLine(info);
                }

                Console.WriteLine("******************************************************************");
            }


            catch (ArgumentException ex)
            {


            }


        }


        public static void InvestigateProcessModuleSet()
        {
            Process theProc = null;


            try
            {
                theProc = Process.GetProcessById(Process.GetCurrentProcess().Id);
                Console.WriteLine(theProc?.ProcessName);

                Console.WriteLine("Here are the threads used by:{0}", theProc.ProcessName);

                
                ProcessModuleCollection theThreads = theProc.Modules;

                foreach (ProcessModule pt in theThreads)
                {
                    
                    string info = $"-->Module Name: {pt.ModuleName}\t Memory Size:{pt.ModuleMemorySize}\tSite:{pt.Site}";

                    Console.WriteLine(info);
                }


                Console.WriteLine("******************************************************************");
            }


            catch (ArgumentException ex)
            {


            }




        }

    }
}
