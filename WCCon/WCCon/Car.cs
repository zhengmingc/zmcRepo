using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCon
{
    public class CarEventArgs : EventArgs
    {
        public readonly string msg;

        public CarEventArgs(string message)
        {
            msg = message;
        }
    }

    public enum EnginState
    {
        EngineAlive,
        EngineDead
    }
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool _carIsDead;

        public EnginState State;

        public Car()
        {
            MaxSpeed = 100;
        }
        public  Car(string name, int maxSp,int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        public void AccelerateTry(int delta)
        {
            if (Exploded != null)
               Exploded(this,new CarEventArgs("Sorry, this car is dead"));
        }
        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                if (Exploded != null)
                    Exploded(this, new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed)&& AboutToBlow !=null)
                {
                    AboutToBlow(this, new CarEventArgs("Carefull buddy ! Gone slow"));
                }
                if (CurrentSpeed > MaxSpeed)
                    _carIsDead = true;
                else
                {
                    Console.WriteLine("CurrentSpeed ={0}",CurrentSpeed);
                }
            }

        }

        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;

    }


    public class SportsCar :Car{}
}
