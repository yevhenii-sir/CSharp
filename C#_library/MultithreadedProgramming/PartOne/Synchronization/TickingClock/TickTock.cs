using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class TickTock
    {
        [MethodImplAttribute(MethodImplOptions.Synchronized)]
        public void Tick(bool running)
        {
            if (!running)
            {
                Monitor.Pulse(this);
                return;
            }

            Console.Write("тик ");
            Monitor.Pulse(this);
            Monitor.Wait(this);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Tock(bool running)
        {
            if (!running)
            {
                Monitor.Pulse(this);
                return;
            }

            Console.WriteLine("так");
            Monitor.Pulse(this);
            Monitor.Wait(this);
        }
    }
}
