using System;
using System.Diagnostics;

namespace LearnCSharpOther
{ 
    static class TimeSpanDemo
    {
        static void Main(string[] args)
        {
            Stopwatch stWch = Stopwatch.StartNew();
            DateTime start = DateTime.Now;

            for (int i = 1; i <= 1000; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0) Console.WriteLine();
            }
            
            stWch.Stop();
            TimeSpan span = DateTime.Now - start;
            
            Console.WriteLine($"Время выполнения: {span:c}");
            Console.WriteLine($"Время выполнения: {span:g}");
            Console.WriteLine($"Время выполнения: {span:G}");
            Console.WriteLine($"Время выполнения: 0.{span:fff} секунды");
            Console.WriteLine($"Время выполнения: 0.{stWch.Elapsed:fff} секунды");
        }
    }
}

/*

...
Время выполнения: 00:00:00.0331063
Время выполнения: 0:00:00.0331063
Время выполнения: 0:00:00:00.0331063
Время выполнения: 0.033 секунды
Время выполнения: 0.033 секунды

*/
