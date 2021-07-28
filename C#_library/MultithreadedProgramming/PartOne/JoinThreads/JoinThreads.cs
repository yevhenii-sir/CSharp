using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    static class JoinThreads
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток начат.");

            MyThread mt1 = new MyThread("Потомок #1");
            MyThread mt2 = new MyThread("Потомок #2");
            MyThread mt3 = new MyThread("Потомок #3");

            mt1.Thrd.Join();
            Console.WriteLine("Потомок №1 присоидинен.");

            mt2.Thrd.Join();
            Console.WriteLine("Потомок №2 присоидинен.");

            mt3.Thrd.Join();
            Console.WriteLine("Потомок №3 присоидинен.");
            
            Console.WriteLine("Основной поток завешен.");
        }
    }
}
