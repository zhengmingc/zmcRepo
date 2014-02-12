using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomAppDomains
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;

            defaultAD.ProcessExit += (o, s) =>
                {
                    Console.WriteLine("Default AD unloaded !!!!!!!");
                };

            ListAllAssembliesInAppDomain(defaultAD);
            MakeNewAppDomain();
            Console.ReadLine();
        }

        private static void MakeNewAppDomain()
        {
            AppDomain newAD = AppDomain.CreateDomain("SecondAppDomain");

            try
            {
                newAD.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            ListAllAssembliesInAppDomain(newAD);

            AppDomain.Unload(newAD);
        }

        private static void ListAllAssembliesInAppDomain(AppDomain ad)
        {
            var loadedAssemblies = from a in ad.GetAssemblies()
                orderby a.GetName().Name
                select a;

            Console.WriteLine("** here are the assemblies loaded in {0} \n", ad.FriendlyName);

            foreach (var a in loadedAssemblies)
            {
<<<<<<< HEAD
                Console.WriteLine("Name ==>> {0}", a.GetName().Name);
                Console.WriteLine("Version ==>> {0}", a.GetName().Version);
                
=======
                Console.WriteLine(" -> Name :{0}",a.GetName().Name);
                Console.WriteLine(" -> Version : {0} \n");
>>>>>>> f80c41bb1a9b763eba5eb0a3e7d9372a58f4156b
            }
        }
    }
}
