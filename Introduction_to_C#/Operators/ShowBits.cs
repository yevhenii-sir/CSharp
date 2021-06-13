using System;

class ShowBits
{
    static void Main()
    {
        int t;
        byte val;

        val = 123;
        for (t = 128; t > 0; t = t / 2)
        {
            if ((val & t) != 0) Console.Write("1 ");
            if ((val & t) == 0) Console.Write("0 ");
        }
    }
}