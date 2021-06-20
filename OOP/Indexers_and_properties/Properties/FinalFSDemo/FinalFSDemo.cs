using System;

namespace BasicLearnCSharp
{
    static class FinalFSDemo
    {
        static void Main(string[] args)
        {
            FailSoftArray fs = new FailSoftArray(5);
            int x;

            for (int i = 0; i < fs.Length; i++)
            {
                fs[i] = i * 10;
            }

            for (int i = 0; i < fs.Length; i++)
            {
                x = fs[i];
                if (x != -1) Console.Write(x + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < fs.Length + 1; i++)
            {
                fs[i] = i * 10;
                if (fs.Error)
                    Console.WriteLine("Ошибка в индексе " + i);
            }
        }
    }
}
