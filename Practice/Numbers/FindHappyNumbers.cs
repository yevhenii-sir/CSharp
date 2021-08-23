/*
 * Happy Numbers - A happy number is defined by the following process.
 * Starting with any positive integer, replace the number by the sum of
 * the squares of its digits, and repeat the process until the number
 * equals 1 (where it will stay), or it loops endlessly in a cycle which
 * does not include 1. Those numbers for which this process ends in 1 are
 * happy numbers, while those that do not end in 1 are unhappy numbers.
 * Display an example of your output here. Find first 8 happy numbers.
 */

using System;
using System.Collections.Generic;

namespace LearnCSharpOther
{
    static class FindHappyNumbers
    {
        private static int SumDigits(int n)
        {
            int result = 0;

            while (n > 0)
            {
                int digit = n % 10;
                n /= 10;
                result += digit * digit;
            }

            return result;
        }
        
        private static bool HappyNumbers(int startNumber)
        {
            HashSet<int> set = new HashSet<int>();
            int result = SumDigits(startNumber);
            set.Add(result);

            while (true)
            {
                if (result == 1) return true;
                
                result = SumDigits(result);

                if (set.Contains(result)) return false;

                set.Add(result);
            }
        }

        static void Main(string[] args)
        {
            int countHappyNumbers = 0;

            Console.Write("Введите число для начала поиска cчастливого числа: ");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            
            while (countHappyNumbers < 8)
            {
                bool tempResult = HappyNumbers(startNumber);
                if (tempResult)
                {
                    Console.WriteLine($"{countHappyNumbers + 1}) Число {startNumber} являеться счастливым.");
                    countHappyNumbers++;
                }

                startNumber++;
            }
        }
    }
}

/*

Введите число для начала поиска cчастливого числа: 12
1) Число 13 являеться счастливым.
2) Число 19 являеться счастливым.
3) Число 23 являеться счастливым.
4) Число 28 являеться счастливым.
5) Число 31 являеться счастливым.
6) Число 32 являеться счастливым.
7) Число 44 являеться счастливым.
8) Число 49 являеться счастливым.

*/
