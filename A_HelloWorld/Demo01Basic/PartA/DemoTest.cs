
namespace Demo1Basic
{
    class DemoTest
    {
        static void Main(string[] args)
        {
            int resultA = SimpleTools.Calculator.Mul(10, 13);
            Console.WriteLine(resultA);

            Console.WriteLine("-------------");
            double resultB = SuperCalculator.Calculator.Div(10, 0);
            Console.WriteLine(resultB);

        }
    }
}