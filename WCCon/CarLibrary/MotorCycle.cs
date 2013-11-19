using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
   [SerializableAttribute]
   public class MotorCycle
   {
       [NonSerialized]
       float weightOfCurrentPassengers;

       bool hasRadioSystem;
       bool hashHeadSet;
       bool hasSissyBar;
   }
}
