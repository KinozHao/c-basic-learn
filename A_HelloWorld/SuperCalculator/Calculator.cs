//这个一个Lib工程,可以不包含Main方法
namespace SuperCalculator
{
    public class Calculator
    {
        public static int Sub(int x, int y)
        {
            return x + y;
        }
        public static int Mul(int k, int x)
        {
            return k * x;
        }

        public static double Div(int k, int x)
        {
            if (x == 0)
            {
                //无穷的意思
                return double.PositiveInfinity;
            }
            else
            {
                return k / x;
            }
        }
    }
}