using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Operator
{
    //进制转换相关
    public class baseConversion
    {

        public void Conver() {
            uint x = uint.MaxValue;
            Console.WriteLine(x);
            //最大uint值转换为二进制 string类型
            string binStr = Convert.ToString(x, 2);
            Console.WriteLine(binStr);

            try
            {
                //检验是否溢出,不检验的话用unchecked，也可以作为代码块使用
                uint y = checked(x + 1);
                Console.WriteLine(y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stack over flow！！！");
            }
        }

    }
}
