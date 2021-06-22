using System;

namespace BasicLearnCSharp
{
    static class Shapes
    {
        static void Main(string[] args)
        {
            ColorTriangle t1 = new ColorTriangle("синий", "прямоугольный", 8.0, 12.0);
            ColorTriangle t2 = new ColorTriangle("красный", "равнобедренный", 2.0, 2.0);
            
            Console.WriteLine("Сведения об объекте t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            t1.ShowColor();
            Console.WriteLine("Площадь равна " + t1.Area());
            
            Console.WriteLine();
            
            Console.WriteLine("Сведения об объекте t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            t2.ShowColor();
            Console.WriteLine("Площадь равна " + t2.Area());
        }
    }
}
