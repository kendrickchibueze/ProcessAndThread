using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProcessAndThread
{
    internal class EnumeratingLoadedAssemblies
    {



        public static void EnumeratingLoadedAssembliesWithinAppDomain()
        {
            //Get access to the Appdomain for the current thread
            AppDomain defaultAD = AppDomain.CurrentDomain;
            //Now get all loaded assemblies in the default App domain
            Assembly [] loadedAssemblies = defaultAD.GetAssemblies();
            Console.WriteLine("**********Here are the Assemblies Loaded in {0} *****\n", defaultAD.FriendlyName);

            foreach(Assembly a in loadedAssemblies)
            {
                Console.WriteLine($"Name, Version: {a.GetName().Name}: {a.GetName().Version}");
            }
        }

    }
}
