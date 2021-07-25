using System;

namespace LearnCSharpOther
{ 
    static class SimpleClock
    {
        static void Main(string[] args)
        {
            string t;

            DateTime dt = DateTime.Now;
            int seconds = dt.Second;

            for (;;)
            {
                dt = DateTime.Now;

                if (seconds != dt.Second)
                {
                    Console.Clear();
                    seconds = dt.Second;
                    t = dt.ToString("T");

                    if (dt.Minute == 0 && dt.Second == 0)
                        t = t + "\a";
                    
                    Console.WriteLine(t);
                }
            }
        }
    }
}
