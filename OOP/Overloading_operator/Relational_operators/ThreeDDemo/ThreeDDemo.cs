using System;

namespace BasicLearnCSharp
{
    static class ThreeDDemo
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(5, 6, 7);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD(1, 2, 3);
            ThreeD d = new ThreeD(6, 7, 5);
            
            Console.Write("Координаты точки а: ");
            a.Show();

            Console.Write("Координаты точки b: ");
            b.Show();
            
            Console.Write("Координаты точки c: ");
            c.Show();
            
            Console.Write("Координаты точки d: ");
            d.Show();

            Console.WriteLine();
            
            
            if (a > c) Console.WriteLine("a > c true");
            if (a < c) Console.WriteLine("a < c true");
            if (a > b) Console.WriteLine("a > b true");
            if (a < b) Console.WriteLine("a < b true");
            
            if (a > d) Console.WriteLine("a > d true");
            else if (a < d) Console.WriteLine("a < d true");
            else Console.WriteLine("Точки a и d находяться на одном растоянии от начала отсчета");
        }
    }
}
