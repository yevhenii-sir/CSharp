using System;
using System.Threading.Tasks;

namespace LearnCSharpMultiThrProgramming
{
    static class ReturnTaskValuesDemo
    {
        static bool MyTask()
        {
            return true;
        }

        static int SumIt(object v)
        {
            int x = (int) v;
            int sum = 0;

            for (; x > 0; sum += x--) {};

            return sum;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            Task<bool> tsk = Task<bool>.Factory.StartNew(MyTask);

            Console.WriteLine("Результат после выполнения задачи MyTask: " + tsk.Result);

            Task<int> tsk2 = Task<int>.Factory.StartNew(SumIt, 3);
            Console.WriteLine("Результат после выполнения задачи SumIt: " + tsk2.Result);
            
            tsk.Dispose();
            tsk2.Dispose();
            
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
