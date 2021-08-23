/*
 * Coin Flip Simulation - Write some code that simulates flipping
 * a single coin however many times the user decides. The code
 * should record the outcomes and count the number of tails and heads.
 */

using System;

namespace LearnCSharpOther
{
    static class CoinFlipSimulation
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberHeads = 0, numberTails = 0;

            Console.Write("Количество подбрасываний: ");
            int numberTosses = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= numberTosses; i++)
                if (random.Next(-1, 1) == 0)
                    numberHeads++;
                else
                    numberTails++;

            Console.WriteLine($"Орлов: {numberHeads} шт - {(double)(numberHeads * 100) / numberTosses:#.000}%" +
                              $"\nРешек: {numberTails} шт - {(double)(numberTails * 100) / numberTosses:#.000}% ");
        }
    }
}

/*

Количество подбрасываний: 100000
7.519
Орлов: 50050 шт - 50.050%
Решек: 49950 шт - 49.950% 

*/
