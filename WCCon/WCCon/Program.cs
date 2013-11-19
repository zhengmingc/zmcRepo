using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Xml.Schema;
using MyExtensionsLibrary;
using MyShapes;



namespace WCCon
{
   
    class Program
    {
        public delegate Car ObtainCarDelegate();

        public delegate void MyGenericDelegate<T>(T arg);

        static void Main()
        {
            Test22();

            

            Console.ReadLine();
        }

        private static void Test22()
        {
            HorseAndBuggy testHorseAndBuggy = new HorseAndBuggy();
        }

  }
}
