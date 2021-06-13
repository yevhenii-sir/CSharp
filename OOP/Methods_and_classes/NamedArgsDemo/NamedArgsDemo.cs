using System;

namespace BasicLearnCSharp
{
    static class NamedArgsDemo
    {
        static bool IsFactor(int val, int divisior)
        {
            if ((val % divisior) == 0) return true;
            return false;
        }
        
        static void Main(string[] args)
        {
             if (IsFactor(10, 2)) 
                 Console.WriteLine("2 - множитель 10");
             
             if (IsFactor(val: 10, divisior: 2))
                 Console.WriteLine("2 - множитель 10");

             if (IsFactor(divisior: 2, val: 10))
                 Console.WriteLine("2 - множитель 10");
             
             if (IsFactor(10, divisior: 2)) 
                 Console.WriteLine("2 - множитель 10");
        }
    }
}
