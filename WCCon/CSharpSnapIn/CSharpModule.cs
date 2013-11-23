﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSnappableTypes;
using System.Windows.Forms;

namespace CSharpSnapIn
{
    [CompanyInfo(CompanyName = "Wenwen's Company",CompanyUrl = "www.wenwen.com")]
    public class CSharpModule:IAppFunctionality
    {   
        void  IAppFunctionality.DoIt()
        {
            MessageBox.Show("You have just used the C# snap in");
        }
    }
}
