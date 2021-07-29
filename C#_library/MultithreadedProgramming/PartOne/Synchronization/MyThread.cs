using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class MyThread
    {
        public Thread Thrd;
        private int[] a;
        private int answer;

        private static SumArray sa = new SumArray();

        public MyThread(string name, int[] nums)
        {
            a = nums;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        public void Run()
        {
            Console.WriteLine(Thrd.Name + " начат.");

            answer = sa.SumIt(a);
            
            Console.WriteLine("Сума для потока " + Thrd.Name + " равна " + answer);
            
            Console.WriteLine(Thrd.Name + " завершен.");
        }
    }
}
