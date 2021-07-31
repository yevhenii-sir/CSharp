using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class TickTock
    {
        private object lockOn = new object();

        public void Tick(bool running)
        {
            lock (lockOn)
            {
                if (!running)
                {
                    Monitor.Pulse(lockOn);
                    return;
                }
                
                Console.Write("тик ");
                Monitor.Pulse(lockOn);
                Monitor.Wait(lockOn);
            }
        }

        public void Tock(bool running)
        {
            lock (lockOn)
            {
                if (!running)
                {
                    Monitor.Pulse(lockOn);
                    return;
                }
                
                Console.WriteLine("так");
                Monitor.Pulse(lockOn);
                Monitor.Wait(lockOn);
            }
        }
    }
}
