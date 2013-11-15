using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeName = "";

            do
            { 
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.WriteLine("or enter Q to quit");

                typeName = Console.ReadLine();

                if (typeName.ToUpper() == "Q")
                {
                    break;
                }

                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine("");
                    ListVariousStats(t);
                    ListFields(t);
                    ListProperties(t);
                    ListMethods(t);
                    ListInterfaces(t);
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, cannot find the type");
                }

            } while (true);
        }

        static void ListMethods(Type t)
        {
            Console.WriteLine("*****Methods*****");



            var mis = from n in t.GetMethods()
                select n;
            
            foreach (var mi in mis)
            {
                string retVal = mi.ReturnType.FullName;
                string paramInfo = "(";

                foreach (var pi in mi.GetParameters())
                {
                    paramInfo += string.Format("{0} {1}", pi.ParameterType, pi.Name);
                }

                paramInfo += ")";

                Console.WriteLine("->{0} {1} {2}",retVal,mi.Name,paramInfo);
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
