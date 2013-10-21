using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Media;
using MyExtensionsLibrary;


namespace WCCon
{
    public class PeopleCollection : IEnumerable
    {
        
        private readonly Dictionary<string,Person> _arPeople = new Dictionary<string,Person>();

        public Person this[string name]
        {
            get { return _arPeople[name]; }

            set { _arPeople[name]=value; }
        }

        public void ClearPeople()
        {
            _arPeople.Clear();
        }

        public int Count
        {
            get { return _arPeople.Count; }
        }

        public IEnumerator GetEnumerator()
        {
           return _arPeople.GetEnumerator();
        }
    }

    class Program
    {
        static void Main()
        {
            Test4();
        }


        static void Test4()
        {
            MyCalc mc = new MyCalc();

            Console.WriteLine("11+23 = {0}",mc.Add(11,23));
            Console.WriteLine("11-23 = {0}",((IBasicMath)mc).Subtract(11,23));

          
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
