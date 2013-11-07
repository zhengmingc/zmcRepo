using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;


namespace CarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("just a test");
            SportsCar sc = new SportsCar("sports car",250,10);
            sc.TurboBoost();

            MiniCar mini = new MiniCar("minicar",1200,12);
            mini.TurboBoost();
           

            AppSettingsReader ar = new AppSettingsReader();
            int numbOfTimes = (int)ar.GetValue("RepeatCount", typeof(int));

            string textColor = (string)ar.GetValue("TextColor", typeof (string));

            Console.ForegroundColor = (ConsoleColor) Enum.Parse(typeof (ConsoleColor), textColor);

            for (int i = 0; i < numbOfTimes; i++)
            {
                Console.WriteLine("Wenwen");
            }

            Console.ReadLine();
        }
    }
}
