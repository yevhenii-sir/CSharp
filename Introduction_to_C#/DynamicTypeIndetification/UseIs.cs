using System;

namespace LearnCSharp
{
    class A {}
    class B : A {}
    
    static class UseIs
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            if (a is A)
                Console.WriteLine("a имеет тип А");
            
            if (b is A)
                Console.WriteLine("b совместим с А, поскольку он производный от А");
            
            if (a is B)
                Console.WriteLine("Не выводится, поскольку а на производный от B");
            
            if (b is B)
                Console.WriteLine("b имеет тип B");
            
            if (a is object)
                Console.WriteLine("a имеет тип object");
        }
    }
}
