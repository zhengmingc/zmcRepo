using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using MyExtensionsLibrary;


namespace WCCon
{
   
    class Program
    {
        public delegate Car ObtainCarDelegate();

        public delegate void MyGenericDelegate<T>(T arg);

        static void Main()
        {
            Test17();
        }

        private static void Test17()
        {
            throw new NotImplementedException();
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
