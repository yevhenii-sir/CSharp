using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    static class PassArgDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток начат.");

            MyThread mt1 = new MyThread("Потомок #1",5);
            MyThread mt2 = new MyThread("Потомок #2", 3);

            do
            {
                Thread.Sleep(100);
            } while (mt1.Thrd.IsAlive | mt2.Thrd.IsAlive);

            Console.WriteLine("Основной поток завешен.");
        }
    }
}
