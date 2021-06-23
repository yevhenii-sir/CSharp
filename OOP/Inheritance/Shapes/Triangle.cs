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

        public Triangle(double x) : base(x, "треугольник")
        {
            Style = "равнобедренный";
        }
        
        public Triangle(string s, double w, double h) : base(w, h, "треугольник")
        {
            Style = s;
        }

        public Triangle(Triangle ob) : base(ob)
        {
            Style = ob.Style;
        }

        public override double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + Style);
        }
    }
}
