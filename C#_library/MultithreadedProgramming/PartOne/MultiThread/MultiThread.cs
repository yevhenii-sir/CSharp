using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    static class MultiThread
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток начат.");

            MyThread mt = new MyThread("Потомок #1");

            Thread newThread = new Thread(mt.Run);
            
            newThread.Start();
            do
            {
                Console.Write(".");
                Thread.Sleep(100);
            } while (mt.Count != 10);
            
            Console.WriteLine("Основной поток завешен.");
        }
    }
}

/*

Основной поток начат.
.Потомок #1 начат.
.....В потоке Потомок #1, Count = 0
....В потоке Потомок #1, Count = 1
.....В потоке Потомок #1, Count = 2
.....В потоке Потомок #1, Count = 3
.....В потоке Потомок #1, Count = 4
.....В потоке Потомок #1, Count = 5
.....В потоке Потомок #1, Count = 6
.....В потоке Потомок #1, Count = 7
.....В потоке Потомок #1, Count = 8
.....В потоке Потомок #1, Count = 9
Потомок #1 завершен.
Основной поток завешен.

*/
