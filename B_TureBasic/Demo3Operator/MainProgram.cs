using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Operator 概念 本质 优先级 运算顺序 
namespace Demo3Operator
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            /*Person person1 = new Person();
            Person person2 = new Person();

            person1.Name = "Lucy";
            person2.Name = "Philip";
            List<Person> TOGETHER
                = person1 + person2;
            TOGETHER.ForEach(person => { Console.WriteLine(person.Name); });
            Console.WriteLine("---------------------------------------------");
            int[] arr = { 23, 42, 43, 23, 23 };
            Console.WriteLine("数组的输出:"+arr[4]);*/

            Console.WriteLine("---------------------------------------------");

            //1.创建具有泛型的字典对象
            Dictionary<string, Person> dictionary = new Dictionary<string, Person>();
            //2.创建100个学生，对应的成绩都是100，把这些学生加入到directionary中
            for (int i = 0; i <= 100; i++)
            {
                Person person = new Person
                {
                    Name = "s_" + i.ToString(),
                    Score = 100
                };
                dictionary.Add(person.Name, person);
;
            }
            //根据dictionary获取第六个学生的score
            Person person6 = dictionary["s_6"];
            Console.WriteLine(person6.Score);

            //获取默认数据类型
            bool bo = default(bool);
            Console.WriteLine(bo);

            //ENUM TEST
            Level level = default(Level);
            Console.WriteLine(level);

        }
    }
    class Person
    {
        public string Name;
        public int Score;
        public static List<Person> operator +(Person boy,Person girl) {
            List<Person> list = new List<Person>();
            list.Add(boy);
            list.Add(girl);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = boy.Name + girl.Name;
                list.Add(child);
            }
            return list;
        }
    }
}
