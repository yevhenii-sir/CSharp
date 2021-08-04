using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCSharpMultiThrProgramming
{
    static class DemoTask
    {
        static void MyTask()
        {
            Console.WriteLine("MyTask() #" + Task.CurrentId + " запущен");
            
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask() #" + Task.CurrentId + ", подсчет равен " + count);
            }
            
            Console.WriteLine("MyTask() #" + Task.CurrentId + " завершен");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            Task tsk = new Task(MyTask);
            Task tsk2 = new Task(MyTask);
            
            tsk.Start();
            tsk2.Start();
            
            Console.WriteLine("Индетификатор задачи tsk: " + tsk.Id);
            Console.WriteLine("Индетификатор задачи tsk2: " + tsk2.Id);

            Task.WaitAll(tsk, tsk2);
            
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
