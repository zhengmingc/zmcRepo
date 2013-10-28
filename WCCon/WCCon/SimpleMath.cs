using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCon
{
    public delegate int BinaryOp(int x, int y);

    public class SimpleMath
    {
        public delegate void MathMessage(string msg, int result);

        public MathMessage mmDelegate;

        public void SetMathHandler(MathMessage target)
        {
            mmDelegate = target;
        }
        public void Add(int x, int y)
        {
            if (mmDelegate != null)
            {
                mmDelegate("Adding has completed", x + y);

            }

        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
