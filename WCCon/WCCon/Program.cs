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
        
        private ArrayList arPeople = new ArrayList();

        public Person this[int index]
        {
            get { return (Person)arPeople[index]; }

            set { arPeople.Insert(index, value); }
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
            PeopleCollection myPeople = new PeopleCollection();

            myPeople[0] = new Person("Homer", 40);

            myPeople[1] = new Person("Wenwen", 18);

            myPeople[2] = new Person("Zhengming", 58);

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number :{0}", i);
                Console.WriteLine("Name is : {0} and Age is : {1}", myPeople[i].Name, myPeople[i].Age);
                
            }
        }
    }
}
