using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Xml.Schema;
using MyExtensionsLibrary;


namespace WCCon
{
   
    class Program
    {
        public delegate Car ObtainCarDelegate();

        public delegate void MyGenericDelegate<T>(T arg);

        static void Main()
        {
            Test21();

            Console.ReadLine();
        }

        private static void Test21()
        {
            string[] currentVideoGames =
            {
                "Morrowwind",
                "Uncharted 2",
                "Fallout 3",
                "Daxter",
                "System Shock 2"
            };

            var subset = currentVideoGames.Where(game => game.Contains(" "))
                .OrderBy(game => game).Select(game => game);

            foreach (var p in subset)
            {
                Console.WriteLine(p);
            }
        }

        private static void Test20()
        {
            double[] temps = {2.0, -21.3, 8, -4, 0, 8.2};

            Console.WriteLine("Max temp :{0}", (from t in temps select t).Sum());
        }

        private static void Test19()
        {
          List<string> myCars = new List<string>{"Yugo","Aztec","BMW"};
          List<string> yourCars = new List<string>{"BMW","Saab","Aztec"};
        
          var carDiff = (from myCar in myCars 
                        select myCar).Concat(from yourCar in yourCars select yourCar);
           
          foreach (var c in carDiff)
            {
                Console.WriteLine("{0}",c);
            }
           
        }



        #region test method
        private static void Test18()
        {
            ProductInfo[] itemsInStrocks = new[]
            {
                new ProductInfo
                {
                    Name = "Mac's Coffee",
                    Description = "Coffee with TEETH",
                    NumberInStock = 24
                },
                new ProductInfo
                {
                    Name = "Milk Maid Milk",
                    Description = "Milk cow's love",
                    NumberInStock = 100
                },

                new ProductInfo
                {
                    Name = "Pure Silk Tofu",
                    Description = "Bland as Possible",
                    NumberInStock = 120
                },

                new ProductInfo
                {
                    Name = "Cruchy Pops",
                    Description = "Cheezy,peppery goodness",
                    NumberInStock = 2
                },
            };


          

           
            
            foreach (var productInfo in GetArrayPro(itemsInStrocks))
            {
                Console.WriteLine(productInfo.ToString());
            }

            

        }

        static Array GetArrayPro(IEnumerable<ProductInfo> list)
        {
            ///////
            var allProducts = from itemsInStrock in list
                              orderby itemsInStrock.NumberInStock  
                              select itemsInStrock;

            return allProducts.ToArray();
        }

        private static void Test17()
        {
            ArrayList myCars = new ArrayList()
            {
                new Car {PetName = "Henry", CurrentSpeed = 20, MaxSpeed = 200},
                new Car {PetName = "Daisy", CurrentSpeed = 30, MaxSpeed = 300},
                new Car {PetName = "Mary", CurrentSpeed = 40, MaxSpeed = 400},
            };

            var myCarsEnum = myCars.OfType<Car>();

            var fastCars = from myCar in myCarsEnum
                where myCar.MaxSpeed > 250 && myCar.PetName == "Daisy"
                select myCar;

            foreach (var fast in fastCars)
            {
                Console.WriteLine("Name is {0}",fast.PetName);
            }

            Console.ReadLine();
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



        #endregion


    }
}
