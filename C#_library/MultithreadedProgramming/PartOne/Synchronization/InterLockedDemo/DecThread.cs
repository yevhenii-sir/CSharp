using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class DecThread
    {
        public Thread Thrd;
        
        public DecThread(string name)
        {
            Thrd = new Thread(this.Run) {Name = name};
            Thrd.Start();
        }

        void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Interlocked.Decrement(ref SharedRes.Count);
                Console.WriteLine(Thrd.Name + " Count = " + SharedRes.Count);
            }
        }
    }
}
