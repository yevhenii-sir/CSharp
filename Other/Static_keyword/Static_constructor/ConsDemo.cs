using System;

namespace BasicLearnCSharp
{
    static class ConsDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cons.alpha);
            Cons ob = new Cons();
            Console.WriteLine("Cons.alpha: " + Cons.alpha);
            Console.WriteLine("ob.beta: " + ob.beta);
        }
    }
}
