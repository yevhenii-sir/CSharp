using System;

namespace LearnCSharp
{
    delegate int InOp(int end);

    static class StatementLambdaDemo
    {
        static void Main(string[] args)
        {
            InOp fact = n =>
            {
                int r = 1;
                for (int i = 1; i <= n; i++)
                {
                    r = i * r;
                }

                return r;
            };
            
            Console.WriteLine("Факториал числа 3 равен: " + fact(3));
            Console.WriteLine("Факториал числа 5 равен: " + fact(5));
        }
    }
}
