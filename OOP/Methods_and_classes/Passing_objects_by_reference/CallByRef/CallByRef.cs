using System;

namespace BasicLearnCSharp
{
    static class CallByRef
    {
        static void Main(string[] args)
        {
            Test ob = new Test(15, 20);

            Console.WriteLine("a и b до вызова: " + ob.a + " " + ob.b);
            
            ob.Change(ob);
            
            Console.WriteLine("a и b после вызова: " + ob.a + " " + ob.b);
        }
    }
}
