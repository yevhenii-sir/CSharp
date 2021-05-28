using System;

namespace BasicLearnCSharp
{
    static class CallByValue
    {
        static void Main(string[] args)
        {
            Test ob = new Test();

            int a = 15, b = 20;
            
            Console.WriteLine("a и b до вызова: " + a + " " + b);
            
            ob.NoChange(a, b);
            
            Console.WriteLine("a и b после вызова: " + a + " " + b);
        }
    }
}
