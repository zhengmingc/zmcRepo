using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBindingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly a = null;
            Console.WriteLine("Start here");
            try
            {
                a = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Go here 1");
                Console.WriteLine(e.Message);
                return;
            }

            if (a != null)
                CreateUsingLateBinding(a);

            Console.ReadLine();
        }

        private static void CreateUsingLateBinding(Assembly a)
        {
            try
            {
                Console.WriteLine("Go here 2");
                Type miniCar = a.GetType("CarLibrary.MiniCar");

                object obj = Activator.CreateInstance(miniCar);

                Console.WriteLine("Creating a object of {0} using late binding",obj);

                MethodInfo mi = miniCar.GetMethod("TurnOnRadio");

                mi.Invoke(obj, new object[]{true,2});
            }
            catch (Exception ex)
            {
                Console.WriteLine("Go here 1");
               Console.WriteLine(ex.Message);
            }
        }
    }
}
