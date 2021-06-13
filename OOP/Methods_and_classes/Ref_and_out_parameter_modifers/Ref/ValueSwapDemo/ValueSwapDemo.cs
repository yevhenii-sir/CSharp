using System;

namespace BasicLearnCSharp
{
    static class ValueSwapDemo
    {
        static void Main(string[] args)
        {
            ValueSwap ob = new ValueSwap();
            int x = 10, y = 20;

            Console.WriteLine("x и y до вызова: " + x + " " + y);
            
            ob.Swap(ref x, ref y);
            
            Console.WriteLine("x и y после вызова: " + x + " " + y);
        }
    }
}
