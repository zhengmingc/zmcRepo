using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLibrary
{
    public enum EnginState
    {
        EngineAlive,
        EngineDead
    }

    public enum MusicMedia
    {
        musicCd,
        musicTape,
        musicRadio,
        musicMp3
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
            MessageBox.Show("Car Library 2.0.0.0");
        }

        public Car(string name, int maxSp, int currSp)
        {
            MessageBox.Show("Car Library 2.0.0.0");
            PetName = name;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }

        public abstract void TurboBoost();

        public void TurnOnRadio(bool musicOn, MusicMedia mm)
        {
            if (musicOn)
            {
                MessageBox.Show(string.Format("Jamming {0}", mm));
            }

            else
            {
                MessageBox.Show("Quiet time..");
            }
        }
    }
    
    
}
