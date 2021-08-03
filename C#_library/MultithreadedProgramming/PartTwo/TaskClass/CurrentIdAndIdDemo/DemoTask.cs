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
            
            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            
            Console.WriteLine("Основной поток завершен.");
        }
    }
}

/*

Основной поток запущен.
Индетификатор задачи tsk: 1
Индетификатор задачи tsk2: 2
.MyTask() #1 запущен
MyTask() #2 запущен
....В методе MyTask() #2, подсчет равен 0
В методе MyTask() #1, подсчет равен 0
.....В методе MyTask() #2, подсчет равен 1
В методе MyTask() #1, подсчет равен 1
.....В методе MyTask() #2, подсчет равен 2
В методе MyTask() #1, подсчет равен 2
.....В методе MyTask() #2, подсчет равен 3
В методе MyTask() #1, подсчет равен 3
.....В методе MyTask() #2, подсчет равен 4
В методе MyTask() #1, подсчет равен 4
.....В методе MyTask() #2, подсчет равен 5
В методе MyTask() #1, подсчет равен 5
.....В методе MyTask() #1, подсчет равен 6
В методе MyTask() #2, подсчет равен 6
.....В методе MyTask() #1, подсчет равен 7
В методе MyTask() #2, подсчет равен 7
.....В методе MyTask() #1, подсчет равен 8
В методе MyTask() #2, подсчет равен 8
.....В методе MyTask() #1, подсчет равен 9
MyTask() #1 завершен
В методе MyTask() #2, подсчет равен 9
MyTask() #2 завершен
..........Основной поток завершен.

 */
