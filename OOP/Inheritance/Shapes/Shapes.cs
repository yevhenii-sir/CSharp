using System;

namespace BasicLearnCSharp
{
    static class Shapes
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("равнобедренный", 4.0, 4.0);
            Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);

            Console.WriteLine("Сведения об объекте t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Площадь равна " + t1.Area());
            
            Console.WriteLine();
            
            Console.WriteLine("Сведения об объекте t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Площадь равна " + t2.Area());
        }
    }
}
