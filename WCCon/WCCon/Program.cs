using System;
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
            Test13();
        }

        private static void Test13()
        {
           Car myCar = new Car("BMW",100,10);

            myCar.AboutToBlow += CallWhenExploded;
            myCar.AboutToBlow += MyCarOnAboutToBlow;


            for (int i = 0; i < 6; i++)
            {
                myCar.Accelerate(20);
            }

            Console.ReadLine();
        }

        private static void MyCarOnAboutToBlow(string msgForCaller)
        {
            
        }


        private static void CallWhenExploded(string msg)
        {
            Console.WriteLine("Car is going to explode! {0}",msg);
        }

        private static void CallYouHere(string msg)
        {
            Console.WriteLine("Call you here ! {0}",msg);
        }

        private static void Test12()
        {
            MyGenericDelegate<string> stringDel = new MyGenericDelegate<string>(StringArg);
            stringDel("test1");

            MyGenericDelegate<int>  intDel = new MyGenericDelegate<int>(IntArg);

            IntArg(22);

            Console.ReadLine();
        }

        private static void StringArg(string arg)
        {
            Console.WriteLine("Calling StringArg with {0}",arg);
        }

        private static void IntArg(int arg)
        {
            Console.WriteLine("Calling IntArg with {0}",arg);
        }
        private static void Test11()
        {
            ObtainCarDelegate targetA = new ObtainCarDelegate(GetBasicCar);
            ObtainCarDelegate targetB = new ObtainCarDelegate(GetSportsCar);
            
            Console.WriteLine("Obtained a {0} : ",targetA());
            Console.WriteLine("Obtained b {0} : ",targetB());

            Console.ReadLine();

        }

        private static Car GetBasicCar()
        {
            return new Car("Zippy", 100, 55);
        }

        private static SportsCar GetSportsCar()
        {
            return new SportsCar();
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
