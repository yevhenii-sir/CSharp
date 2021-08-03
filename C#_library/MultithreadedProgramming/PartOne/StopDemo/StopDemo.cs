using System;
using System.Threading;

namespace LearnCSharpFramework
{
    class StopDemo
    {
        static void Main(string[] args)
        {
            MyThread mt1 = new MyThread("Мой Поток");

            Thread.Sleep(1000);

            Console.WriteLine("Прерывание потока.");
            mt1.Thrd.Abort();

            mt1.Thrd.Join();

            Console.WriteLine("Основной поток прерван.");

            Console.ReadLine();
        }
    }
}

/*
 
Мой Поток started.
1 2 3 4 5 6 7 8 9 10
11 12 13 14 15 16 17 18 19 20
21 22 23 24 25 26 27 28 29 30
31 32 33 34 35 36 37 38 39 40
Прерывание потока.
Основной поток прерван.
 
 */