using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCon
{
    public class Car
    {
        public int Speed { get; set; }

        public  Car(int speed)
        {
            Speed = speed;
        }

        public void SpeedUp()
        {
            ++Speed;
            Console.WriteLine("speed of car is :{0}",Speed);
        }
    }

    public static class CarExtension
    {
        public static void SlowDown(this Car c)
        {
            --c.Speed;
            Console.WriteLine("speed of car is :{0}",c.Speed);
        }
 
    }

   
}
