using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCSharpMultiThrProgramming
{
    static class DemoTaskCancel
    {
        static void MyTask(object ct)
        {
            CancellationToken cancelTok = (CancellationToken) ct;
            
            cancelTok.ThrowIfCancellationRequested();
            Console.WriteLine("MyTask() запущен");

            for (int count = 0; count < 10; count++)
            {
                if (cancelTok.IsCancellationRequested)
                {
                    Console.WriteLine("Получен запрос на отмену задачи.");
                    cancelTok.ThrowIfCancellationRequested();
                }
                
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask() подсчет равен " + count);
            } 
            Console.WriteLine("MyTask() завешен");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            CancellationTokenSource cancelTokSrc = new CancellationTokenSource();

            Task tsk = Task.Factory.StartNew(MyTask, cancelTokSrc.Token, cancelTokSrc.Token);
            
            Thread.Sleep(2000);
            try
            {
                cancelTokSrc.Cancel();
                tsk.Wait();
            }
            catch (AggregateException exc)
            {
                if (tsk.IsCanceled)
                    Console.WriteLine("\nЗадача tsk отменена\n");
            }
            finally
            {
                tsk.Dispose();
                cancelTokSrc.Dispose();
            }
            
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
