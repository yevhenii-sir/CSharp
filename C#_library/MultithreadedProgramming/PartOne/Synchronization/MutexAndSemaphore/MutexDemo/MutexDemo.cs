using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    static class MutexDemo
    {
        static void Main(string[] args)
        {
            IncThread mt1 = new IncThread("Инкрементированый Поток", 5);
            Thread.Sleep(1);
            DecThread mt2 = new DecThread("Декрементирующий Поток", 5);
            mt1.Thrd.Join();
            mt2.Thrd.Join();
        }
    }
}

