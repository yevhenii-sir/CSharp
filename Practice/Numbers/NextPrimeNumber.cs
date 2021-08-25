using System;

namespace LearnCSharpOther
{
    static class NextPrimeNumber
    {
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;

            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        static int NextPrime(int n)
        {
            while (!IsPrime(++n)){};
            return n;
        }

        static void Main(string[] args)
        {
            Console.Write("Начальное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Для поиска следующеего простого числа нажимайте Y, для выхода N.");
            while (Console.ReadKey(true).KeyChar == 'Y')
            {
                n = NextPrime(n);
                Console.WriteLine("Cледующее простое число: " + n);
            }
        }
    }
}

/*

Начальное число: 16
Для поиска следующеего простого числа нажимайте Y, для выхода N.
Cледующее простое число: 17
Cледующее простое число: 19
Cледующее простое число: 23
Cледующее простое число: 29
Cледующее простое число: 31
Cледующее простое число: 37
Cледующее простое число: 41
Cледующее простое число: 43
Cледующее простое число: 47
Cледующее простое число: 53

*/
