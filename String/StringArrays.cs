using System;
using System.Globalization;

namespace BasicLearnCSharp
{
    class StringArrays
    {
        static void Main(string[] args)
        {
            string[] str = {"Это", "очень", "простой", "тест."};
            
            Console.WriteLine("Исходный масив: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine("\n");

            str[1] = "тоже";
            str[3] = "до предела тест!";
            
            Console.WriteLine("Видоизмененный масив: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
        }
    }
}