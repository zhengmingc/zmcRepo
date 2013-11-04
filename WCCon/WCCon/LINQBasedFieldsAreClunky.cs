using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WCCon
{
    class LINQBasedFieldsAreClunky
    {
        private static string[] currentVideoGames =
        {
            "Morrowind",
            "Fallout 3",
            "Daxter"
        };

        private IEnumerable<string> subset =
            from g in currentVideoGames
            where g.Contains(" ")
            select g;


    }
}
