using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCode
{
    public class Student
    {
        public string stu_name;
        public string stu_email;
        public string stu_phone;
        public string stu_age;

        public Student()
        {

        }

        public Student(string stu_name, string stu_email, string stu_phone, string stu_age)
        {
            this.stu_name = stu_name;
            this.stu_email = stu_email;
            this.stu_phone = stu_phone;
            this.stu_age = stu_age;
        }

        public static double CircleArea(double x)
        {
            return Math.PI * (x * x);
        }
    }
}
