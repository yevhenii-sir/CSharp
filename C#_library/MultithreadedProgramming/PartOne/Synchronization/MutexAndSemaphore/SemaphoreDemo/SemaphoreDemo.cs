namespace LearnCSharpMultiThrProgramming
{
    static class SemaphoreDemo
    {
        static void Main(string[] args)
        {
            MyThread mt1 = new MyThread("Поток #1");
            MyThread mt2 = new MyThread("Поток #2");
            MyThread mt3 = new MyThread("Поток #3");

            mt1.Thrd.Join();
            mt1.Thrd.Join();
            mt1.Thrd.Join();
        }
    }
}

