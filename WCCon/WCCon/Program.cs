using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCon
{
    public class PeopleCollection : IEnumerable
    {
        
        private Dictionary<string,Person> arPeople = new Dictionary<string,Person>();

        public Person this[string name]
        {
            get { return (Person)arPeople[name]; }

            set { arPeople[name]=value; }
        }

        public void ClearPeople()
        {
            arPeople.Clear();
        }

        public int Count
        {
            get { return arPeople.Count; }
        }

        public IEnumerator GetEnumerator()
        {
           return arPeople.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            test1();
        }

        private static void test1()
        {
            Point a = new Point(10, 34);
            Point b = new Point(23, 11);

            Point c = a+b;

            Point d = a-b;

            Console.WriteLine("Point c is : {0}", c.ToString());
            Console.WriteLine("Point d is : {0}", d.ToString());

            Console.ReadLine();
        }
    }
}
