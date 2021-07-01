using System;

namespace LearnCSharp
{
    delegate void CountIt();
    
    static class AnonMethDemo
    {
        static void Main(string[] args)
        {
            CountIt count = delegate
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
            };

            count();
        }
    }
}
