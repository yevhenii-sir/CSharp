namespace LearnCSharpMultiThrProgramming
{
    static class InterLockedDemo
    {
        static void Main(string[] args)
        {
            IncThread mt1 = new IncThread("Инкрементирующий Поток");
            DecThread mt2 = new DecThread("Декрементирующий Поток");

            mt1.Thrd.Join();
            mt2.Thrd.Join();
        }
    }
}


