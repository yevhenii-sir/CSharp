using System;

namespace LearnCSharpOther
{ 
    static class FormatDemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:F2} {0:F3} {0:E}", 10.12345);
            
            Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);

        }
    }
}
