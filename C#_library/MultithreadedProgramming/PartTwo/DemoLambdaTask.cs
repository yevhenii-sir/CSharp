using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCSharpMultiThrProgramming
{
    static class DemoLambdaTask
    {
        static void Main(string[] args)
        {
            Task tsk = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Задача запущена.");

                for (int count = 0; count < 10; count++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Подсчет в задаче равен " + count);
                }

                Console.WriteLine("Задача завершена.");
            });

            tsk.Wait();
            tsk.Dispose();
            
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
