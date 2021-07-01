using System;

namespace LearnCSharp
{
    delegate void CountIt(int end);
    
    static class AnonMethDemo2
    {
        static void Main(string[] args)
        {
            CountIt count = delegate(int end)
            {
                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i);
                }
            };

            count(3);
            Console.WriteLine();
            count(5);
        }
    }
}
