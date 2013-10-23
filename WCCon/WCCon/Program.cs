using System;
using System.Data;
using System.Media;
using MyExtensionsLibrary;


namespace WCCon
{
   
    class Program
    {
        static void Main()
        {
            Test10();
        }

        private static void Test10()
        {
           Car c1= new Car("SlugBug",100,10);
           c1.RegisterWithCarEngine(CallMeHere);
       
           Console.WriteLine("****Speeding up****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            c1.UnregisterWithCarEngine(CallMeHere);

            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadLine();

        }



        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n****Message from car object****");
            Console.WriteLine("=>{0}",msg);
            Console.WriteLine("************\n");
        }

        public static void CallMeHere(string msg)
        {
            Console.WriteLine("=>{0}",msg.ToUpper());
        }

        private static void Test9()
        {
            SimpleMath sm = new SimpleMath();

            BinaryOp b = new BinaryOp(SimpleMath.Add);

            DisplayDelegateInfo(b);

            Console.ReadLine();
        }


        private static void Test7()
        {
            var purchaseItem = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new
                {
                    Color = "Bright pink",
                    Make = "BMW",
                    Year = 1981
                }
            };

            ReflectOverAnonymousType(purchaseItem);

            Console.ReadLine();

        }

        public static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
              Console.WriteLine("Method Name is :{0}",d.Method);
              Console.WriteLine("Target is :{0}",d.Target);
            }
        }

        private static void Test6()
        {
            var firstCar = new
            {
                Color = "Bright pink",
                Make = "BMW",
                Year = 1981
            };

            var secondCar = new
            {
                Color = "Bright pink",
                Make = "BMW",
                Year = 1981
            };

            Console.WriteLine(firstCar.GetType().Name==secondCar.GetType().Name ? "Same anonymous object" : "Not the same anonyous object!");

            Console.ReadLine();

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
