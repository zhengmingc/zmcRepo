using System;
using CarLibrary;

namespace SharedClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shared Assembly");
            SportsCar sc = new SportsCar("BMW",300,20);
            sc.TurboBoost();
            Console.ReadLine();

        }
    }
}
