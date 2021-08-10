using System;

namespace LearnCSharpOther
{
    static class DigitSeparatorsAndBinaryLiterals
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use Digit Separators");
            Console.WriteLine("Integer: " + 123_456);
            Console.WriteLine("Long: " + 123_456_789L);
            Console.WriteLine("Float: " + 123_456.1234F);
            Console.WriteLine("Double: " + 123_456.12);
            Console.WriteLine("Decimal: " + 123_456.12M);
            
            Console.WriteLine("----------------------");
            
            Console.WriteLine("Use Binary Literals");
            Console.WriteLine("Sixteen: " + 0b0001_0000);
            Console.WriteLine("Thirty Two: " + 0b0010_0000);
            Console.WriteLine("Sixty Four: " + 0b0100_0000);
        }
    }
}
