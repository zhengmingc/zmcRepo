using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCon
{
    partial class CarLocator
    {
        public bool CarAvailableInZipCode(string zipCode)
        {
            OnZipCodeLookup(zipCode);
            return true;
        }

        partial void OnZipCodeLookup(string make);
    }
}
