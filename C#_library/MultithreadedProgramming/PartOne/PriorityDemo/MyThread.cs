using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class MyThread
    {
        public int Count;
        public Thread Thrd;

        private static bool stop = false;
        private static string currentName;

        public MyThread(string name)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            currentName = name;
        }

        public void Run(object num)
        {
            Console.WriteLine("Поток" + Thrd.Name + " начат.");
            do
            {
                Count++;
                if (currentName != Thrd.Name)
                {
                    currentName = Thrd.Name;
                    Console.WriteLine("В потоке " + currentName);
                }
                
            } while (stop == false && Count < 1_000_000_000);

            stop = true;
            Console.WriteLine("Поток " + Thrd.Name + " завершен.");
        }
    }
}
