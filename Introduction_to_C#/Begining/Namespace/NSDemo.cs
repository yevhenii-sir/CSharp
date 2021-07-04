using System;

namespace LearnCSharp
{
    static class NSDemo
    {
        static void Main(string[] args)
        {
            Counter.CountDown cd1 = new Counter.CountDown(10);

            int i;
            do
            {
                i = cd1.Conunt();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();

            Counter.CountDown cd2 = new Counter.CountDown(20);

            do
            {
                i = cd2.Conunt();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();
            
            cd2.Reset(4);
            do
            {
                i = cd2.Conunt();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();
        }
    }
}
