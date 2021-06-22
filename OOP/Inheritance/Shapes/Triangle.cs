using System;

namespace BasicLearnCSharp
{
    public class Triangle : TwoDShape
    {
        private string Style;

        public Triangle()
        {
            Style = "null";
        }

        public Triangle(double x) : base(x)
        {
            Style = "равнобедренный";
        }
        
        public Triangle(string s, double w, double h) : base(w, h)
        {
            Style = s;
        }

        public Triangle(Triangle ob) : base(ob)
        {
            Style = ob.Style;
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
