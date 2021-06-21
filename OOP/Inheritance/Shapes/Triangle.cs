using System;

namespace BasicLearnCSharp
{
    public class Triangle : TwoDShape
    {
        private string Style;

        public Triangle(string s, double w, double h)
        {
            Width = w;
            Height = h;
            Style = s;
        }

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
