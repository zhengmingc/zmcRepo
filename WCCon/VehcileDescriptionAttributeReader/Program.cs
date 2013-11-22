using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

using AttributedCarLibrary;

namespace VehcileDescriptionAttributeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectOnAttributeUsingEarlyBinding();
            Console.ReadLine();
        }

        private static void ReflectOnAttributeUsingEarlyBinding()
        {
            Type t = typeof (Winnebago);

            object[] customAtts = t.GetCustomAttributes(false);

            foreach (VehicleDescriptionAttribute customAtt in customAtts)
            {
                Console.WriteLine("->{0}\n",customAtt.Description);
            }
        }
    }
}
