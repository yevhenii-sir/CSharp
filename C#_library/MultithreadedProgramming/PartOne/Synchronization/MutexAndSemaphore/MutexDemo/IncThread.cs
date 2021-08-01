using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class IncThread
    {
        private int num;
        public Thread Thrd;
        
        public IncThread(string name, int n)
        {
            Thrd = new Thread(this.Run) {Name = name};
            num = n;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " ожидает мьютекс.");

            SharedRes.Mtx.WaitOne();
            
            Console.WriteLine(Thrd.Name + " получает мьютекс.");

            do
            {
                Thread.Sleep(500);
                SharedRes.Count++;
                Console.WriteLine("В потоке " + Thrd.Name + ", SharedRes.Count = " + SharedRes.Count);
                num--;
            } while (num > 0);
            Console.WriteLine(Thrd.Name + " освобождает мьютекс.");
            SharedRes.Mtx.ReleaseMutex();
        }
    }
}
