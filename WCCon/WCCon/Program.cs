using System;
using System.Collections;
using System.Collections.Generic;


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
            Test2();
        }

        private static void Test2()
        {
            Point a;
            a = new DerivedPoint();

            DerivedPoint b = (DerivedPoint)a;

            Console.WriteLine("b is :{0}", b);
            Console.ReadLine();


        }
    }
}
