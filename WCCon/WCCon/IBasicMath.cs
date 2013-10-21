

namespace WCCon
{
    interface IBasicMath
    {
        int Add(int x, int y);
    }

    class MyCalc : IBasicMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    static class MathExtensions
    {
        public static int Subtract(this IBasicMath itf, int x, int y)
        {
            return x - y;
        }
    }

}
