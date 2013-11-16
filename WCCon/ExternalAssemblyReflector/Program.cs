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
            asmName ="System.Windows.Forms,"+
                "Version=4.0.0.0"+
                "PublicKeyToken=";
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
