using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class MyThread
    {
        public int Count;
        private string thrdName;

        public MyThread(string name)
        {
            Count = 0;
            thrdName = name;
        }

        public void Run()
        {
            Console.WriteLine(thrdName + " начат.");

            do
            {
                Thread.Sleep(500);
                Console.WriteLine($"В потоке " + thrdName + ", Count = " + Count);
                Count++;
            } while (Count < 10);
            
            Console.WriteLine(thrdName + " завершен.");
        }
    }
}
