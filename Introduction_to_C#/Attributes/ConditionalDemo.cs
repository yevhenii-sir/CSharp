#define TRIAL

using System;
using System.Diagnostics;
using System.Reflection;

namespace LearnCSharp
{
    class ConditionalDemo
    {
        [Conditional("TRIAL")] //применяется в методах void
        private void Trial()
        {
            Console.WriteLine("Пробная версия, не " +
                              "придназначена для распостранения.");
        }

        [Conditional("RELEASE")]
        private void Release()
        {
            Console.WriteLine("Окончательная робочая версия.");
        }
        
        static void Main()
        {
            Test t = new Test();
            
            t.Trial();
            
            t.Release();
        }
    }
}
