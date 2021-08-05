using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCSharpMultiThrProgramming
{
    static class ContinuationDemo
    {
        static void MyTask()
        {
            Console.WriteLine("MyTask() запущен");

            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask() подсчет равен " + count);
            }
            
            Console.WriteLine("MyTask() завершен");
        }

        static void ContTask(Task t)
        {
            Console.WriteLine("Продолжение запущено");

            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В продолжении подсчет равен " + count);
            }
            
            Console.WriteLine("Продолжение завершено");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            Task tsk = new Task(MyTask);
            Task tskCont = tsk.ContinueWith(ContTask);
            
            tsk.Start();

            tskCont.Wait();
            
            tsk.Dispose();
            tskCont.Dispose();
            
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
