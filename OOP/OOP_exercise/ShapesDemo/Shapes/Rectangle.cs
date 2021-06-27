using System;

namespace Exercise.Shapes
{
    public class Rectangle : Shape
    {
        public int X { get; set; }
        
        public int Y { get; set; }

        public Rectangle(int x, int y, string color) : base(color)
        {
            X = x;
            Y = y;
        }

        public override void Draw()
        {
            Console.WriteLine($"{Color} прямоугольник с координатами точек Х: {X}, Y: {Y}");
        }
    }
}
