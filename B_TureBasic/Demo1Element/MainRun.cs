using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1Element
{
    internal class MainRun
    {
        static void Main(string[] args)
        {
            /*string a = "hell";
            Console.WriteLine(a);
            String b = "dfafda";
            Console.WriteLine(b);
            var c = "helldfa";
            Console.WriteLine(c);*/

            /*BasicSF bsf = new BasicSF();
            bsf.PrintXto1(10);
            Console.WriteLine("--------------");
            bsf.PrintXto1II(3);

            SumFrom1toX sff = new SumFrom1toX();
            int normalvalue = sff.getSum(100);
            Console.WriteLine("循环思想:"+normalvalue);

            int valuedg = sff.getSumDG(100);
            Console.WriteLine("递归思想:" + valuedg);

            int valuegs = sff.getSumGS(100);
            Console.WriteLine("高斯思想:" + valuegs);


            int numDisks = 3; // 汉诺塔的圆盘数量
            char sourcePeg = 'A'; // 起始柱子
            char auxiliaryPeg = 'B'; // 辅助柱子
            char targetPeg = 'C'; // 目标柱子

            Console.WriteLine($"移动 {numDisks} 个圆盘从柱子 {sourcePeg} 到柱子 {targetPeg}：");

            Hanoi.SolveHanoi(numDisks, sourcePeg, auxiliaryPeg, targetPeg);

            //数据类型测试
            valueTest.someValue();*/

            //枚举类型测试
            valueTest.enumTest();

        }
    }
}
