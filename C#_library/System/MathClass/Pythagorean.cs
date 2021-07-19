using System;

namespace LearnCSharpOther
{
    static class Pythagorean
    {
        static void Main(string[] args)
        {
            double s1, s2, hypot;
            string str;
            
            Console.WriteLine("Введите длину первой стороны треугольника: ");
            str = Console.ReadLine();
            s1= Double.Parse(str);
            
            Console.WriteLine("Введите длину второй стороны треугольника: ");
            str = Console.ReadLine();
            s2 = Double.Parse(str);

            hypot = Math.Sqrt(s1 * s1 + s2 * s2);
            Console.WriteLine("Длина гипотенузы равна {0:#.####}", hypot);
        }
    }
}
