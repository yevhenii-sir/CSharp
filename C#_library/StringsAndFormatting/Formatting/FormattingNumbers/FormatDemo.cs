using System;

namespace LearnCSharpOther
{ 
    static class FormatDemo
    {
        static void Main(string[] args)
        {
            double v = 17688.65849;
            double v2 = 0.15;
            int x = 21;
            
            Console.WriteLine("{0:F2}", v);
            Console.WriteLine("{0:N5}", v);
            Console.WriteLine("{0:e}", v);
            Console.WriteLine("{0:r}", v);
            Console.WriteLine("{0:p}", v2);
            Console.WriteLine("{0:X}", x);
            Console.WriteLine("{0:D12}", x);
            Console.WriteLine("{0:C}", 189.99);
        }
    }
}

/*

17688.66
17,688.65849
1.768866e+004
17688.65849
15.000%
15
000000000021
$189.99

*/


