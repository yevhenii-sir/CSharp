using System;

namespace LearnCSharpOther
{
    static class NextPrimeNumber
    {
        private static int _i = 2;

        static bool IsPrime(int n)
        {
            if (n == 0 || n == 1)
                return false;

            if (n == _i) return true;

            if (n % _i == 0)
                return false;

            _i++;
            return IsPrime(n);
        }

        static int NextPrime(int n)
        {
            _i = 2;
            
            while (!IsPrime(++n))
                _i = 2;
            
            return n;
        }

        static void Main(string[] args)
        {
            Console.Write("Начальное число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            char ch;
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
