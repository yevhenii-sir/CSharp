using System;

namespace BasicLearnCSharp
{
    static class FSDemo
    {
        static void Main(string[] args)
        {
            FailSoftArray fs = new FailSoftArray(5);
            int x;
            
            Console.WriteLine("Скрытый сбой.");
            for (int i = 0; i < (fs.Length * 2); i++)
            {
                fs[i] = i * 10;
            }

            for (int i = 0; i < (fs.Length * 2); i++)
            {
                x = fs[i];
                if (x != -1) Console.Write(x + " ");
            }
            
            Console.WriteLine("");
            
            Console.WriteLine("\nСбой с уведомлениями об ошибках.");
            for (int i = 0; i < (fs.Length * 2); i++)
            {
                fs[i] = i * 10;
                if (fs.ErrFlag) Console.WriteLine($"fs[{i}] вне границ");
            }

            for (int i = 0; i < (fs.Length * 2); i++)
            {
                x = fs[i];
                if (!fs.ErrFlag) Console.Write(x + " ");
                else
                {
                    Console.WriteLine($"fs[{i}] вне границ");
                }
            }
        }
    }
}
