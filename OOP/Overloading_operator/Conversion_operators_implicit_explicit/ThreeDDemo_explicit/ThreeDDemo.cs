using System;

namespace BasicLearnCSharp
{
    static class ThreeDDemo
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD();
            int i;
            
            Console.Write("Координаты точки а: ");
            a.Show();

            Console.Write("Координаты точки b: ");
            b.Show();
            
            Console.Write("Координаты точки c: ");
            c.Show();
            
            Console.WriteLine();

            c = a + b;
            Console.Write("Резаультат сложения a + b: ");
            c.Show();
            Console.WriteLine();

            i = (int)a;
            Console.WriteLine("Результат присваивания i = a: " + i);
            Console.WriteLine();

            i = (int)a * 2 - (int)b;
            Console.WriteLine("Результат вычисления выражения a * 2 - b: " + i);
        }
    }
}
