using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class MyThread
    {
        public Thread Thrd;
        private TickTock ttOb;

        public MyThread(string name, TickTock tt)
        {
            Thrd = new Thread(this.Run);
            ttOb = tt;
            Thrd.Name = name;
            Thrd.Start();
        }

        public void Run()
        {
            if (Thrd.Name == "Tick")
            {
                for (int i = 0; i < 5; i++) ttOb.Tick(true);
                ttOb.Tock(false);
            }
            else
            {
                for (int i = 0; i < 5; i++) ttOb.Tock(true);
                ttOb.Tick(false);
            }
        }
    }
}
