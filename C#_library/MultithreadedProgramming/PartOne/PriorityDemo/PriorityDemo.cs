using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    static class PriorityDemo
    {
        static void Main(string[] args)
        {
            MyThread mt1 = new MyThread("с высоким приоритетом");
            MyThread mt2 = new MyThread("с низким приоритетом");

            mt1.Thrd.Priority = ThreadPriority.Highest;
            mt2.Thrd.Priority = ThreadPriority.BelowNormal;
            
            mt1.Thrd.Start();
            mt2.Thrd.Start();

            mt1.Thrd.Join();
            mt2.Thrd.Join();
            
            Console.WriteLine();
            Console.WriteLine("Поток " + mt1.Thrd.Name + " досчитал до " + mt1.Count);
            Console.WriteLine("Поток " + mt2.Thrd.Name + " досчитал до " + mt2.Count);
        }
    }
}

/*

...
Поток с низким приоритетом завершен.
Поток с высоким приоритетом завершен.

Поток с высоким приоритетом досчитал до 640156752
Поток с низким приоритетом досчитал до 1000000000

*/
