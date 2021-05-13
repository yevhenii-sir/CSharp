using System;

namespace Basic_Learn_Csharp
{
    class Jagged
    {
        static void Main()
        {
            var jagget = new[]
            {
                new[] {1, 2, 3, 4},
                new[] {9, 8, 7},
                new[] {11, 12, 13, 14, 15}
            };

            for (int j = 0; j < jagget.Length; j++)
            {
                for (int i = 0; i < jagget[j].Length; i++)
                {
                    Console.Write(jagget[j][i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}