using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DefaultAppDomainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayDADstatus();
            //ListAllAssembliesInAppDomain();
            InitDAD();
            Console.ReadLine();
        }

        private static void InitDAD()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;

            defaultAD.AssemblyLoad += (o, s) =>
                {
                    Console.WriteLine("{0} has been loaded", s.LoadedAssembly.GetName().Name);
                };

        }

        private static void ListAllAssembliesInAppDomain()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;
            Assembly[] loadedAssemblies = defaultAD.GetAssemblies();

            foreach (Assembly a in loadedAssemblies)
            {
                Console.WriteLine("==>> Name :{0}", a.GetName().Name);
                Console.WriteLine("==>> Version : {0}", a.GetName().Version);
            }
            
        }

        private static void DisplayDADstatus()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;

            Console.WriteLine("Name of this domain :" + defaultAD.FriendlyName);
            Console.WriteLine("ID of domain : " + defaultAD.Id);
            Console.WriteLine("is this the default domain ? " + defaultAD.IsDefaultAppDomain());
            Console.WriteLine("Base directory of this domain : " + defaultAD.BaseDirectory);


        }
    }
}
