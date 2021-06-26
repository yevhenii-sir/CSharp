using System;

namespace LearnCSharpInterface
{
    static class FQIFNames
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            
            Console.WriteLine("Вызов метода IMyIF_A.Meth(): " +
                              ob.MethA(3));
            
            Console.WriteLine("Вызов метода IMyIF_B.Meth(): " +
                              ob.MethB(3));
        }
    }
}
