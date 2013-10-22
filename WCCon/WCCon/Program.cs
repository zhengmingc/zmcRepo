using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Media;
using MyExtensionsLibrary;


namespace WCCon
{
   
    class Program
    {
        static void Main()
        {
            Test5();
        }

        private static void Test5()
        {
            var myCar = new
            {
                Color = "Bright pink",
                Make = "BMW",
                Year = 1981
            };

            Console.WriteLine("color is :{0}",myCar.Color);

            ReflectOverAnonymousType(myCar);

            Console.ReadLine();
        }

        private static void ReflectOverAnonymousType(object obj)
        {
            Console.WriteLine("obj is an instance of :{0}",obj.GetType().Name);

            Console.WriteLine("Base calss of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);

            Console.WriteLine("obj.ToString() = {0}",obj.ToString());

            Console.WriteLine("obj.GetHashCode() ={0}",obj.GetHashCode());
        }
        static void Test4()
        {
            MyCalc mc = new MyCalc();

            Console.WriteLine("11+23 = {0}",mc.Add(11,23));
            Console.WriteLine("11-23 = {0}",((IBasicMath)mc).Subtract(11,23));

            ReflectOverAnonymousType(mc);
            
            Console.ReadLine();
        }




        private static void Test2()
        {
            Point a;
            a = new DerivedPoint();

            DerivedPoint b = (DerivedPoint)a;

            Console.WriteLine("b is :{0}", b);
           
        }

        public static void Test3()
        {
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();

            System.Data.DataSet d = new DataSet();
            d.DisplayDefiningAssembly();

            System.Media.SoundPlayer sp = new SoundPlayer();
            sp.DisplayDefiningAssembly();

            Console.WriteLine("Value of myInt : {0}",myInt);
            Console.WriteLine("Reverse digits of myInt :{0}",myInt.ReverseDigits());


            myInt.Foo();
            myInt.Foo("ints that foo has msg argument");
            Console.ReadLine();

        }
    }
}
