using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCode
{
    public class Stu_Info
    {
        public static void showInfo(Student stu)
        {
            Console.WriteLine("YOUR DB INFORMATION:");
            Console.WriteLine(stu.stu_name + "\n" + stu.stu_email + "\n" + stu.stu_phone + "\n" + stu.stu_age);
        }
    }
}
