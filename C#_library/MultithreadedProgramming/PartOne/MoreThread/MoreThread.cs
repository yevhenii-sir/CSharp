using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    static class MoreThread
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток начат.");

            MyThread mt1 = new MyThread("Потомок #1");
            MyThread mt2 = new MyThread("Потомок #2");
            MyThread mt3 = new MyThread("Потомок #3");
            
            do
            {
                Console.Write(".");
                Thread.Sleep(100);
            } while (mt1.Count < 10 ||
                     mt2.Count < 10 || 
                     mt3.Count < 10);
            
            Console.WriteLine("Основной поток завешен.");
        }
    }
}

/*

Основной поток начат.
.Потомок #1 начат.
Потомок #2 начат.
Потомок #3 начат.
....В потоке Потомок #1, Count = 0
В потоке Потомок #2, Count = 0
В потоке Потомок #3, Count = 0
.....В потоке Потомок #1, Count = 1
В потоке Потомок #3, Count = 1
В потоке Потомок #2, Count = 1
.....В потоке Потомок #3, Count = 2
В потоке Потомок #1, Count = 2
В потоке Потомок #2, Count = 2
.....В потоке Потомок #1, Count = 3
В потоке Потомок #3, Count = 3
В потоке Потомок #2, Count = 3
.....В потоке Потомок #1, Count = 4
В потоке Потомок #3, Count = 4
В потоке Потомок #2, Count = 4
.....В потоке Потомок #1, Count = 5
В потоке Потомок #3, Count = 5
В потоке Потомок #2, Count = 5
.....В потоке Потомок #3, Count = 6
В потоке Потомок #1, Count = 6
В потоке Потомок #2, Count = 6
.....В потоке Потомок #3, Count = 7
В потоке Потомок #2, Count = 7
В потоке Потомок #1, Count = 7
.....В потоке Потомок #3, Count = 8
В потоке Потомок #1, Count = 8
В потоке Потомок #2, Count = 8
.....В потоке Потомок #1, Count = 9
В потоке Потомок #3, Count = 9
Потомок #1 завершен.
Потомок #3 завершен.
В потоке Потомок #2, Count = 9
Потомок #2 завершен.
Основной поток завешен.

*/
