using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public enum EnginState
    {
        EngineAlive,
        EngineDead
    }

    public abstract class Car
    {
        public string PetName { get; set; }

        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EnginState egnState = EnginState.EngineAlive;

        public EnginState EnginState { get { return egnState; } }

        public Car()
        {
            
        }

        public Car(string name, int maxSp, int currSp)
        {
            PetName = name;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }

        public abstract void TurboBoost();
    }
    
    
}
