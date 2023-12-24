using System.Text;

namespace Lesson
{
    public class Program
    {
        class Calculator
        {
            public void Add(int a, int b)
            {
                int res = a + b;
                Console.WriteLine(res);
            }

            public void Subtruct(int a, int b)
            {
                int res = a - b;
                Console.WriteLine(res);
            }

            public void Multiply(int a, int b)
            {
                int res = a * b;
                Console.WriteLine(res);
            }

            public void Divide(int a, int b)
            {
                if (b == 0)
                {
                    Console.WriteLine("You can't divide by zero!");
                }
                else
                {
                    int res = a / b;
                    Console.WriteLine(res);
                }
            }
        }
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                var action = new Calculator();
                action.Add(2, 6);
                action.Subtruct(10, 3);
                action.Multiply(4, 5);
                action.Divide(8, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}