using System;

namespace BasicLearnCSharp
{
    public class Triangle : TwoDShape
    {
        public string Style;

        public double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + Style);
        }
    }
}
