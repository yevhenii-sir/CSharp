using System;

namespace BasicLearnCSharp
{
    static class TwoDIndexerDemo
    {
        static void Main(string[] args)
        {
            FailSoftArray2D fs = new FailSoftArray2D(3, 5);
            int x;
            
            Console.WriteLine("Скрытый сбой.");
            for (int i = 0; i < 6; i++)
                fs[i, i] = i * 10;

            for (int i = 0; i < 6; i++)
            {
                x = fs[i, i];
                if (x != -1) Console.Write(x + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("\nСбой с уведомление об ошибках.");
            for (int i = 0; i < 6; i++)
            {
                fs[i, i] = i * 10;
                if (fs.ErrFlag)
                    Console.WriteLine($"fs[{i}, {i}] вне границ");
            }

            for (int i = 0; i < 6; i++)
            {
                x = fs[i, i];
                if (!fs.ErrFlag) Console.WriteLine(x + " ");
                else
                {
                    Console.WriteLine($"fs[{i}, {i}] вне границ");
                }
            }
        }
    }
}
