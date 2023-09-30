using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1Element
{
    class BasicSF
    {
        //正常写法
        public void PrintXto1(double x)
        {

            for (double i = x; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        //递归写法
        public void PrintXto1II(double x)
        {
            if (x == 1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
                PrintXto1II(x - 1);
            }
        }
    }

    class SumFrom1toX
    {
        //循环思想
        public int getSum(int x)
        {
            int result = 0;
            for (int i = 1; i < x+1; i++)
            {
                result = result + i;
            }
            return result;
        }
        //递归思想
        public int getSumDG(int x)
        {
            if(x == 1)
            {
                return 1;
            }
            else
            {
                int result = x + getSumDG(x-1);
                return result;
            }
        }
        //高斯思想
        public int getSumGS(int x)
        {
            return (1 + x) * x / 2;
        }
    }

}
