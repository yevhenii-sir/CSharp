using System;

namespace CSharpLearn
{
    static class BaseRef
    {
        static void Main(string[] args)
        {
            X x = new X(10);
            X x2;
            Y y = new Y(5, 5);

            x2 = x;
            Console.WriteLine("x2.a: " + x2.a);

            x2 = y;
            Console.WriteLine("x2.a: " + x2.a);

            x2.a = 19;
            //x2.b = 27 //error
        }
    }
}
