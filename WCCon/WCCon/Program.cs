using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Xml.Schema;
using MyExtensionsLibrary;


namespace WCCon
{
   
    class Program
    {
        public delegate Car ObtainCarDelegate();

        public delegate void MyGenericDelegate<T>(T arg);

        static void Main()
        {
            Test18();
        }

        private static void Test18()
        {
           ArrayList myStuff = new ArrayList();
           myStuff.AddRange(new object[]{23,49,true,"wenwen"});
            var newStuff = myStuff.OfType<int>();
            foreach (var i in newStuff)
            {
                Console.WriteLine("{0}",i);
            }

            Console.ReadLine();
        }

        private static void Test17()
        {
            ArrayList myCars = new ArrayList()
            {
                new Car {PetName = "Henry", CurrentSpeed = 20, MaxSpeed = 200},
                new Car {PetName = "Daisy", CurrentSpeed = 30, MaxSpeed = 300},
                new Car {PetName = "Mary", CurrentSpeed = 40, MaxSpeed = 400},
            };

            var myCarsEnum = myCars.OfType<Car>();

            var fastCars = from myCar in myCarsEnum
                where myCar.MaxSpeed > 250 && myCar.PetName == "Daisy"
                select myCar;

            foreach (var fast in fastCars)
            {
                Console.WriteLine("Name is {0}",fast.PetName);
            }

            Console.ReadLine();
        }

        private static void Test16()
        {
            string[] currentVideoGames = {"Morrowwind", "Uncharted 2", "System Shock 2"};

            IEnumerable<string> subset = from currentVideoGame in currentVideoGames
                where currentVideoGame.Contains(" ")
                orderby currentVideoGame
                select currentVideoGame;

           
            foreach (var s in subset)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("type is {0}",subset.GetType().Name);
            Console.WriteLine("assmebly is {0}",subset.GetType().Assembly.GetName().Name);
        }

      


    }
}
