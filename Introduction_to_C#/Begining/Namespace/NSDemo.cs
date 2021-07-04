using System;

namespace LearnCSharp
{
    static class NSDemo
    {
        static void Main(string[] args)
        {
            Counter.CountDown cd1 = new Counter.CountDown(10);
            Counter2.CountDown cd2 = new Counter2.CountDown();

            int i;
            do
            {
                i = cd1.Conunt();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();

            cd2.Count();
        }
    }
}
