using System;

namespace LearnCSharpStreams
{
    public static class AvgNums
    {
        static void Main(string[] args)
        {
            int n;
            Double sum = 0.0;
            double avg, t;
            
            Console.Write("Сколько чисел вы собираетесь ввести: ");
            if (int.TryParse(Console.ReadLine(), out n) == false) return;
            
            Console.WriteLine("Введите " + n + " чисел.");
            for (int i = 0; i < n; i++)
            {
                Console.Write(": ");
                if ((double.TryParse(Console.ReadLine(), out t) == false)) t = 0.0;
                sum += t;
            }

            avg = sum / n;
            Console.WriteLine($"Среднее равно {avg:#.00}");
        }
    }
}
