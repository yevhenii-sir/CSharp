using System;

namespace BasicLearnCSharp
{
    static class Recursion
    {
        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            Console.WriteLine("Факториалы, рассчитаные рекурсивным методом.");
            Console.WriteLine("Факториал числа 3 равен " + f.FactR(3));
            Console.WriteLine("Факториал числа 4 равен " + f.FactR(4));
            Console.WriteLine("Факториал числа 5 равен " + f.FactR(5)); 
            Console.WriteLine();
            
            Console.WriteLine("Факториалы, рассчитаные итерационным методом.");
            Console.WriteLine("Факториал числа 3 равен " + f.FactI(3));
            Console.WriteLine("Факториал числа 4 равен " + f.FactI(4));
            Console.WriteLine("Факториал числа 5 равен " + f.FactI(5)); 
        }
    }
}
