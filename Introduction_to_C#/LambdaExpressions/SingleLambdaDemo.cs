using System;

namespace LearnCSharp
{
    delegate int Incr (int v);

    delegate bool IsEven(int v);

    static class SimpleLambdaDemo
    {
        static void Main(string[] args)
        {
            Incr incr = count => count + 2;
            
            Console.WriteLine("Использование лямбда-выражения incr: ");
            int x = -10;
            while (x <= 0)
            {
                Console.Write(x + " ");
                x = incr(x);
            }
            
            Console.WriteLine();

            IsEven isEven = n => n % 2 == 0;
            Console.WriteLine("Использование лямбда-выражения IsEven: ");
            for (int i = 1; i <= 10; i++)
            {
                if (isEven(i))
                {
                    Console.WriteLine(i + " четное.");
                }
                //Console.Write(isEven(i) ? $"{i} четное.\n" : "");
            }
        }
    }
}
