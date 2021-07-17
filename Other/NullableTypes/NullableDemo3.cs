using System;

namespace LearnCSharpOther
{
    static class NullableDemo3
    {
        static double GetZeroBal()
        {
            Console.WriteLine("В методе GetZeroBalO.");
            return 0.0;
        }
        
        static unsafe void Main(string[] args)
        {
            double? balance = 123.75;
            double currentBalance = balance ?? GetZeroBal();
            
            Console.WriteLine(currentBalance);
        }
    }
}
