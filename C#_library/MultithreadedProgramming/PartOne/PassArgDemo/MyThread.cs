using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class MyThread
    {
        public int Count;
        public Thread Thrd;

        public MyThread(string name, int num)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start(num);
        }

        public void Run(object num)
        {
            Console.WriteLine(Thrd.Name + " начат со счета " + num);

            do
            {
                Thread.Sleep(500);
                Console.WriteLine($"В потоке " + Thrd.Name + ", Count = " + Count);
                Count++;
            } while (Count < (int) num);
            
            Console.WriteLine(Thrd.Name + " завершен.");
        }
    }
}
