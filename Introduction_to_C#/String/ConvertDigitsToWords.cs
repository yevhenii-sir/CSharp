using System;

namespace BasicLearnCSharp
{
    static class ConvertDigitsToWords
    {
        static void Main(string[] args)
        {
            int num, nextdigits, numbdigits;
            int[] n = new int[20];

            string[] digits =
            {
                "нуль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восьемь", "девять"
            };

            num = 1908;
            
            Console.WriteLine("Число: " + num);
            
            Console.WriteLine("Число словами: ");

            nextdigits = 0;
            numbdigits = 0;

            do
            {
                nextdigits = num % 10;
                n[numbdigits] = nextdigits;
                numbdigits++;
                num /= 10;
            } while (num > 0);

            numbdigits--;

            for (;numbdigits >= 0; numbdigits--)
            {
                Console.Write(digits[n[numbdigits]] + " ");
            }
            
            Console.WriteLine();
        }
    }
}
