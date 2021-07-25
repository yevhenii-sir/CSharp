using System;

namespace LearnCSharpOther
{ 
    static class FormatDemo1v3
    {
        static void Main(string[] args)
        {
            double v = 17688.65849;
            double v2 = 0.15;
            int x = 21;


            string str = v.ToString("F2");
            Console.WriteLine(str);

            str = v.ToString("N5");
            Console.WriteLine(str);

            str = v.ToString("E");
            Console.WriteLine(str);

            str = v.ToString("R");
            Console.WriteLine(str);

            str = v2.ToString("P");
            Console.WriteLine(str);

            str = x.ToString("X");
            Console.WriteLine(str);

            str = x.ToString("D12");
            Console.WriteLine(str);

            str = 189.99.ToString("C");
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
