using System;

namespace BasicLearnCSharp
{
    static class ThreeDDemo
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(5, 6, 7);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD();

            
            Console.Write("Координаты точки а: ");
            a.Show();

            Console.Write("Координаты точки b: ");
            b.Show();
            
            Console.Write("Координаты точки c: ");
            c.Show();
            
            Console.WriteLine();

            Console.WriteLine(a ? "Точка а истинна." : "Точка а ложна.");
            Console.WriteLine(b ? "Точка b истинна." : "Точка b ложна.");
            Console.WriteLine(c ? "Точка c истинна." : "Точка c ложна.");
            
            Console.WriteLine();
            
            Console.WriteLine("Управление циклом с помощю объекта класса ThreeD.");
            do
            {
                b.Show();
                b--;
            } while (b);
        }
    }
}
