using System;

namespace LearnCSharpOther
{
    static class LocalFunction
    {
        static int Sum(int a, int b)
        {
            return SumFunc();
            int SumFunc()
            {
                return a + b;
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5, 5));
        }
    }
}
