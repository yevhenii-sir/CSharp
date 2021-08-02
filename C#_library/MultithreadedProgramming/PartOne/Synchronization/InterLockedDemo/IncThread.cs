using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class IncThread
    {
        public Thread Thrd;
        
        public IncThread(string name)
        {
            Thrd = new Thread(this.Run) {Name = name};
            Thrd.Start();
        }

        void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Interlocked.Increment(ref SharedRes.Count);
                Console.WriteLine(Thrd.Name + " Count = " + SharedRes.Count);
            }
        }
    }
}
