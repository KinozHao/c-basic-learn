using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2Basic
{
    internal class ClassTest
    {
        static void Main(string[] args)
        {
            //数学类,用于搞各种计算
            double value = Math.Sqrt(32);
            Console.WriteLine("开方"+value);
            double value2 = Math.Pow(434,4);
            Console.WriteLine("求次方"+value2);

            // 为一个类创建一个实例
            /*(new Form()).Text = "My Form";
            (new Form()).ShowDialog();*/

            // 创建一个实例
            Form myForm = new Form();
            myForm.Text = "脚本编辑器V1.0";
            //myForm.ShowDialog();


        }
    }
}
