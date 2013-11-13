using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void ListMethods(Type t)
        {
            Console.WriteLine("*****Methods*****");



            var names = from n in t.GetMethods()
                select n.Name;
            
            foreach (var name in names)
            {
                Console.WriteLine("->{0}",name);
            }
            Console.WriteLine();
        }


        static void ListFields(Type t)
        {
            Console.WriteLine("*****Fields*****");
            var names = from n in t.GetFields()
                select n.Name;
            foreach (var name in names)
            {
             Console.WriteLine("->{0}",name);   
            }
        }

        static void ListProperties(Type t)
        {
            Console.WriteLine("*****Properties****");
            var names = from n in t.GetProperties()
                select n.Name;
            foreach (var name in names)
            {
             Console.WriteLine("->{0}",name);   
            }

        }

        static void ListInterfaces(Type t)
        {
            Console.WriteLine("******Interfaces*****");

            var names = from n in t.GetInterfaces()
                select n;

            foreach (Type name in names)
            {
                Console.WriteLine("->{0}",name.Name);
            }
        }

        static void ListVariousStats(Type t)
        {
            Console.WriteLine("*****Various Status*****");
            Console.WriteLine("Base calsss is: {0}",t.BaseType);
            Console.WriteLine("Is type abstract?{0}",t.IsAbstract);
            Console.WriteLine("Is type sealed?{0}", t.IsSealed);
            Console.WriteLine("Is type generic?{0}", t.IsGenericType);
            Console.WriteLine("Is type class type?{0}", t.IsClass);
            
        
        }
    }
}
