using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessAndThread
{
    internal class DefaultAppDormain
    {

        public static void InteractingWithDefaultAppDormain()
        {
            //Get access to the AppDormain for the current thread

            //print out various stats for the current domain
            AppDomain defaultAD = AppDomain.CurrentDomain;
           
            Console.WriteLine("Nmae of this Dormain : {0}", defaultAD.FriendlyName);
            Console.WriteLine("ID of this Dormain : {0}", defaultAD.Id);
            Console.WriteLine("Is this the default Domain?: {0} ", defaultAD.IsDefaultAppDomain);
            Console.WriteLine( "Base Directory of this domain : {0}", defaultAD.BaseDirectory);
            Console.WriteLine("Set up Info for this Domain:");
            Console.WriteLine("\t Application Base: {0}", defaultAD.SetupInformation.ApplicationBase);
            Console.WriteLine("\t Target Framework: {0}", defaultAD.SetupInformation.TargetFrameworkName);
        }
    }
}
