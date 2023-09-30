using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1Element
{
    class Hanoi
    {
        public static void SolveHanoi(int numDisks, char source, char auxiliary, char target)
        {
            if (numDisks == 1)
            {
                Console.WriteLine($"将圆盘 1 从柱子 {source} 移动到柱子 {target}");
            }
            else
            {
                // 将 n-1 个圆盘从起始柱子移动到辅助柱子，借助目标柱子作为辅助
                SolveHanoi(numDisks - 1, source, target, auxiliary);

                // 将最大的圆盘从起始柱子移动到目标柱子
                Console.WriteLine($"将圆盘 {numDisks} 从柱子 {source} 移动到柱子 {target}");

                // 将 n-1 个圆盘从辅助柱子移动到目标柱子，借助起始柱子作为辅助
                SolveHanoi(numDisks - 1, auxiliary, source, target);
            }
        }
    }

    // 变量与对象部分内容
    public class valueTest
    {
        public static void someValue()
        {
            // dynamic关机键类似于js中的var
            dynamic var1 = 100;
            Console.WriteLine(var1);
            var1 = "hello vars";
            Console.WriteLine(var1);
        }

        public static void enumTest()
        {
            //windows窗口的三种状态使用的就是枚举类型
            Form form = new Form();
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }


    }
}
