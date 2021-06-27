using System;

namespace Exercise.Shapes
{
    public class Circle : Shape
    {
        public int X { get; set; }
        
        public int Y { get; set; }
        
        public double Radius { get; set; }

        public Circle(int x, int y, double radius, string color) : base(color)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"{Color} круг с радиусом {Radius:#.##} см. " +
                              $"\nРасположен в координатах X: {X}, Y: {Y}");
        }
    }
}
