using System;
using System.Threading.Tasks;

namespace LearnCSharpOther
{
    static class AsyncMethods
    {
        
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static async void FactorialAsync(int n)
        {
            int result = await Task.Run(() => Factorial(n));
            Console.WriteLine($"Факториал числа {n} = {result}");
        }
        
        static void Main(string[] args)
        {
            FactorialAsync(5);
            FactorialAsync(6);

            Console.WriteLine("Некоторая работа");
        }
    }
}
