using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributedCarLibrary
{  
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public sealed class VehicleDescriptionAttribute:System.Attribute
    {
        public string Description { get; set; }

        public VehicleDescriptionAttribute(string vehicalDescription)
        {
            Description = vehicalDescription;
        }

        public VehicleDescriptionAttribute()
        {
            
        }
    }
}
