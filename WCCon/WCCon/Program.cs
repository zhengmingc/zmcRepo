using System;
using System.Collections.Generic;
using System.Data;
using System.Media;
using MyExtensionsLibrary;


namespace WCCon
{
   
    class Program
    {
        public delegate Car ObtainCarDelegate();

        public delegate void MyGenericDelegate<T>(T arg);

        static void Main()
        {
            Test16();
        }

        private static void Test16()
        {
            Car myCar = new Car("BMW",20,100);

            myCar.AboutToBlow += (sender, e) => Console.WriteLine(e.msg);

            myCar.Exploded += (sender, e) => Console.WriteLine(e.msg);

            for (int i = 0; i < 6; i++)
            {
                myCar.Accelerate(20);
            }
        }

        private static void Test15()
        {
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) => Console.WriteLine("Message : {0}, Result :{1}", msg, result));

            m.Add(12,24);
      
        }

        private static void Test14()
        {
            List<int> list = new List<int>();

            list.AddRange(new int[]{20,1,4,5});

            List<int> evenNumbers = list.FindAll(i =>
            {
                Console.WriteLine("Current value is {0}",i);
                bool result =(i%2) == 0;
                return result;
            });

            foreach (var evenNumber in evenNumbers)
            {
                Console.WriteLine("number is {0}",evenNumber);
            }
            

        }


    }
}
