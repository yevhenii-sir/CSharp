using System;

namespace BasicLearnCSharp
{
    static class FinalFSDemo
    {
        static void Main(string[] args)
        {
            FailSoftArray fs = new FailSoftArray(5);

            for (int i = 0; i < fs.Length + 1; i++)
            {
                fs[i] = i * 10;
                if (fs.Error) 
                    Console.WriteLine("Ошибка в индексе " + i);
            }
        }
    }
}
