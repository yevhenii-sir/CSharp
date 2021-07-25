using System;

namespace LearnCSharpOther
{ 
    static class FormatDemo1v2
    {
        static void Main(string[] args)
        {
            double v = 17688.65849;
            double v2 = 0.15;
            int x = 21;
            
            string str = String.Format("{0:F2}", v);
            Console.WriteLine(str);
            
            str = String.Format("{0:N5}", v);
            Console.WriteLine(str);
            
            str = String.Format("{0:E}", v);
            Console.WriteLine(str);
            
            str = String.Format("{0:R}", v);
            Console.WriteLine(str);
            
            str = String.Format("{0:p}", v2);
            Console.WriteLine(str);
            
            str = String.Format("{0:X}", x);
            Console.WriteLine(str);
            
            str = String.Format("{0:D12}", x);
            Console.WriteLine(str);
            
            str = String.Format("{0:C}", 189.99);
            Console.WriteLine(str);
        }
    }
}

/*

17688.66
17,688.65849
1.768866E+004
17688.65849
15.000%
15
000000000021
$189.99

*/


