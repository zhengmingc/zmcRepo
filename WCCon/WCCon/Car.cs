using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCon
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool _carIsDead;

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

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed)&& listOfHandlers !=null)
                {
                    listOfHandlers("Carefull buddy ! Gone slow");
                }
                if (CurrentSpeed > MaxSpeed)
                    _carIsDead = true;
                else
                {
                    Console.WriteLine("CurrentSpeed ={0}",CurrentSpeed);
                }
            }

        }

        public delegate void CarEngineHandler(string msgForCaller);

        private CarEngineHandler listOfHandlers;

        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }

        public void UnregisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

    }


   
}
