using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    static class ManualAndAutoEventDemo
    {
        static void Main(string[] args)
        {
            AutoResetEvent evtObj = new AutoResetEvent(false);

            MyThread mt1 = new MyThread("Событийный Поток 1", evtObj);
            Console.WriteLine("Основной поток ожидает событие.");
            evtObj.WaitOne();
            Console.WriteLine("Основной поток получил уведомление о событии от первого потока.");

            //evtObj.Reset(); - used in the ManualResetEvent class

            mt1 = new MyThread("Событийный Поток 2", evtObj);
            evtObj.WaitOne();
            Console.WriteLine("Основной поток получил уведомление о событии от второго потока.");
        }
    }
}

/*

Основной поток ожидает событие.
Внутри потока Событийный Поток 1
Событийный Поток 1
Событийный Поток 1
Событийный Поток 1
Событийный Поток 1
Событийный Поток 1
Событийный Поток 1 завершен!
Основной поток получил уведомление о событии от первого потока.
Внутри потока Событийный Поток 2
Событийный Поток 2
Событийный Поток 2
Событийный Поток 2
Событийный Поток 2
Событийный Поток 2
Событийный Поток 2 завершен!
Основной поток получил уведомление о событии от второго потока.

 */

