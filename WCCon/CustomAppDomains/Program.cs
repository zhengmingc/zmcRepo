using System;
using System.Collections.Generic;
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
            ListAllAssembliesInAppDomain(defaultAD);
            MakeNewAppDomain();
            Console.ReadLine();
        }

        private static void MakeNewAppDomain()
        {
            AppDomain newAD = AppDomain.CreateDomain("SecondAppDomain");
            ListAllAssembliesInAppDomain(newAD);
        }

        private static void ListAllAssembliesInAppDomain(AppDomain ad)
        {
            var loadedAssemblies = from a in ad.GetAssemblies()
                orderby a.GetName().Name
                select a;

            Console.WriteLine("** here are the assemblies loaded in {0} \n", ad.FriendlyName);

            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine(" -> Name :{0}",a.GetName().Name);
                Console.WriteLine(" -> Version : {0} \n");
            }
        }
    }
}
