using System;

namespace BasicLearnCSharp
{
    static class ThreeDDemo
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c;
            
            Console.Write("Координаты точки а: ");
            a.Show();
            Console.WriteLine();
            
            Console.Write("Координаты точки b: ");
            b.Show();
            Console.WriteLine();

            c = a + b;
            Console.Write("Результат сложения a + b: ");
            c.Show();
            Console.WriteLine();

            c = a + b + c;
            Console.Write("Результат сложения a + b + c: ");
            c.Show();
            Console.WriteLine();

            c = c - a;
            Console.Write("Результат вычетания c - a: ");
            c.Show();
            Console.WriteLine();
            
            c = c - b;
            Console.Write("Результат вычетания c - b: ");
            c.Show();
            Console.WriteLine();
        }
    }
}
