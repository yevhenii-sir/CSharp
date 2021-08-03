using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCSharpMultiThrProgramming
{
    static class DemoTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");
            MyClass mc = new MyClass();

            Task tsk = new Task(mc.MyTask);

            tsk.Start();

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
.MyTask() запущен
....В методе MyTask(), подсчет равен 0
.....В методе MyTask(), подсчет равен 1
.....В методе MyTask(), подсчет равен 2
.....В методе MyTask(), подсчет равен 3
.....В методе MyTask(), подсчет равен 4
.....В методе MyTask(), подсчет равен 5
.....В методе MyTask(), подсчет равен 6
.....В методе MyTask(), подсчет равен 7
.....В методе MyTask(), подсчет равен 8
.....В методе MyTask(), подсчет равен 9
MyTask завершен
..........Основной поток завершен.

 */
