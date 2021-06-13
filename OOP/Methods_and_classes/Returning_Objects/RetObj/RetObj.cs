using System;

namespace BasicLearnCSharp
{
    static class RetObj
    {
        static void Main(string[] args)
        {
            Rect r1 = new Rect(4, 5);
            
            Console.Write("Размеры прямоугольника r1: ");
            r1.Show();
            Console.WriteLine("Площадь прямоугольника r1: " + r1.Area());
            
            Console.WriteLine();

            Rect r2 = r1.Enlarge(2);
            
            Console.Write("Размеры прямоугольника r2: ");
            r2.Show();
            
            Console.WriteLine("Площадь прямоугольика r2: " + r2.Area());
        }
    }
}
