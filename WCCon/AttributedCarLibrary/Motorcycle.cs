using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributedCarLibrary
{   [Serializable]
    [VehicleDescription(Description = "My rocking Harley")]
    public class Motorcycle
    {
     [VehicleDescription(Description = "My rocking Harley")]
     public void PlayMusic(bool on)
     {}
    }

    [VehicleDescription("It is winnebago")]
    public class Winnebago
    {

    }
}
