using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class MyThread
    {
        public Thread Thrd;
        private static Semaphore sem = new Semaphore(2, 2);

        public MyThread(string name)
        {
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine(Thrd.Name + " ожидает разрешения.");

            sem.WaitOne();
            
            Console.WriteLine(Thrd.Name + " получает розрешение.");

            for (char ch = 'A'; ch < 'D'; ch++)
            {
                Console.WriteLine(Thrd.Name + " : " + ch + " ");
                Thread.Sleep(500);
            }
            
            Console.WriteLine(Thrd.Name + " высвобождает разрешение.");

            sem.Release();
        }
    }
}
