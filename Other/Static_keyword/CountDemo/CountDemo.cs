using System;

namespace BasicLearnCSharp
{
    static class CountDemo
    {
        static void Main(string[] args)
        {
            CountInst ob;

            for (int i = 0; i < 10; i++)
            {
                ob = new CountInst();
                Console.WriteLine("Текущий подсчет: " + CountInst.GetCount());
            }
        }
    }
}
