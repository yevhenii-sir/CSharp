using System;

namespace BasicLearnCSharp
{
    static class RefDemo
    {
        static void Main(string[] args)
        {
            RefTest ob = new RefTest();

            int a = 10;
            
            Console.WriteLine("a до вызова: " + a);
            
            ob.Sqr(ref a);
            
            Console.WriteLine("a после вызова: " + a);
            
        }
    }
}
