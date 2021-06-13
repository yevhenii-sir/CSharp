using System;

namespace Basic_Learn_Csharp
{
    class UseRect
    {
        static void Main()
        {
            Rect r1 = new Rect(4, 5);
            Rect r2 = new Rect(7, 9);

            Console.WriteLine("Площадь прямоугольника r1:" + r1.Area());

            Console.WriteLine("Площадь прямоугольника r2:" + r2.Area());
        }
    }
}