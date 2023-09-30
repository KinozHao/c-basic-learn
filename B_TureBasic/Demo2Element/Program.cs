using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//关于变量和对象相关的
namespace Demo2Element
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student(20,"Jack");
            Console.WriteLine(student.name);
            Console.WriteLine(student.age);
            //数组类型
            int[] arr = new int[10];
            arr[0] = 30;
            arr[9] = 345;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            //常量不同java用final 用const
            const int mycode = 2021221300;
            Console.WriteLine(mycode);
        }


    }
    public class Student
    {
        public static int studnet_Num = 20;
        public int age;
        public string name;
        //空参构造函数
        public Student() { }
        //有参构造函数
        public Student(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
