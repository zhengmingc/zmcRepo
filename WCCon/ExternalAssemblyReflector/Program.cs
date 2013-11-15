using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExternalAssemblyReflector
{
    class Program
    {
        static void Main(string[] args)
        {
            string asmName = "";
            Assembly asm = null;

            do
            {
              Console.WriteLine("Type in your assembly:");
                asmName = Console.ReadLine();

                if (asmName.ToUpper() == "Q")
                {
                    break;
                }

                try
                {
                    asm = Assembly.LoadFrom(asmName);
                    DisplayTypesInAsm(asm);
                }

                catch
                {
                    Console.WriteLine("Sorry, can't find assembly.");
                }
            } while (true);
        }


        static void DisplayTypesInAsm(Assembly asm)
        {
            Console.WriteLine("Loaded from GAC?{0}",asm.GlobalAssemblyCache);
            Console.WriteLine("Asm Name:{0}",asm.GetName().Name);
            Console.WriteLine("Asm Version:{0}",asm.GetName().Version);
            Console.WriteLine("Asm culture : {0}",asm.GetName().CultureInfo.DisplayName);
            Type[] types = asm.GetTypes();
          
        }
    }
}
