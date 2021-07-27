using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class MyThread
    {
        public int Count;
        public Thread Thrd;

        public MyThread(string name)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        public void Run()
        {
            Console.WriteLine(Thrd.Name + " начат.");

            do
            {
                Thread.Sleep(500);
                Console.WriteLine($"В потоке " + Thrd.Name + ", Count = " + Count);
                Count++;
            } while (Count < 10);
            
            Console.WriteLine(Thrd.Name + " завершен.");
        }
    }
}
