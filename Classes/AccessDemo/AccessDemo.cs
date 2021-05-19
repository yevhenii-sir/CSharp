using System;

namespace BasicLearnCSharp
{
    static class AccessDemo
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            
            ob.SetAlpha(-99);
            ob.SetBeta(19);
            
            Console.WriteLine("ob.alpha равно: " + ob.GetAlpha());
            Console.WriteLine("ob.beta равно: " + ob.GetBeta());

            ob.gamma = 100;
        }
    }
}
