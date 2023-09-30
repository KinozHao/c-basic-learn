using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCode;

namespace Demo4Operator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.studentReference();
        }



        //测试student类
        public static void studentReference()
        {
            Console.WriteLine("Who are you system v1.0");

            Console.WriteLine("Your name?");

            Console.WriteLine("please enter you name to display");
            string name = Console.ReadLine();
            Console.WriteLine("you are : " + name);
            Student student1 = new Student("jack", "jack@gmail.com", "887326323", "14");
            if (name == student1.stu_name)
            {
                Stu_Info.showInfo(student1);
            }
            else
            {
                Console.WriteLine("you are not jack,we cant tell you his information");
            }
            Console.ReadKey();
            Console.WriteLine("student calculate circle area!");
            Double area = Student.CircleArea(30);
            Console.WriteLine(area);
        }
    }


}
