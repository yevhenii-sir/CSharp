using System;

namespace LearnCSharpMultiThrProgramming
{
    static class TickingClock
    {
        static void Main(string[] args)
        {
            TickTock tt = new TickTock();
            MyThread mt1 = new MyThread("Tick", tt);
            MyThread mt2 = new MyThread("Tock", tt);

            mt1.Thrd.Join();
            mt2.Thrd.Join();
            
            Console.WriteLine("Часы остановлены.");
        }
    }
}

