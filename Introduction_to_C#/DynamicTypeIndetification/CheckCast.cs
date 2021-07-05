using System;

namespace LearnCSharp
{
    class A {}
    class B : A {}
    
    static class CheckCast
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            if (a is B) // проверка, можно ли привести тип через оператор is
                b = (B) a;
            else
                b = null;
            
            if (b == null)
                Console.WriteLine("Привидение типов b = (B) НЕ допустимо.");
            else
                Console.WriteLine("Привидение типов b = (B) допустимо.");

            
            b = a as B; //приведение типов с помоцю опартора as
            
            if (b == null)
                Console.WriteLine("Привидение типов b = (B) НЕ допустимо.");
            else
                Console.WriteLine("Привидение типов b = (B) допустимо.");

        }
    }
}

/*
 
Привидение типов b = (B) НЕ допустимо.
Привидение типов b = (B) НЕ допустимо.

*/
