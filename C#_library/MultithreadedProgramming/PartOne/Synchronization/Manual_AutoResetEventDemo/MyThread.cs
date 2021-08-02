using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class MyThread
    {
        public Thread Thrd;
        public AutoResetEvent mre;

        public MyThread(string name, AutoResetEvent evt)
        {
            Thrd = new Thread(Run) {Name = name};
            mre = evt;
            Thrd.Start();
        }

        void Run()
        {
            Console.WriteLine("Внутри потока " + Thrd.Name);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Thrd.Name);
                Thread.Sleep(500);
            }
            
            Console.WriteLine(Thrd.Name + " завершен!");

            mre.Set();
        }
    }
}
