using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLibrary
{

 
    public class SportsCar:Car

   {
        public SportsCar()
        {
            
        }

        public SportsCar(string name,int maxSpeed, int currSpeed)
            :base(name,maxSpeed,currSpeed)
        {
            
        }
       public override void TurboBoost()
       {
           MessageBox.Show("message from SportsCar");
       }
}

    public class MiniCar : Car
    {
        public MiniCar()
        {
            
        }

        public MiniCar(string name, int maxSp, int  curSp)
            :base(name,maxSp,curSp)
        {
            
        }

        public override void TurboBoost()
        {
            egnState = EnginState.EngineDead;

            MessageBox.Show("Message from MiniCar");
        }


    }
}
