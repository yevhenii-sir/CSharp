namespace BasicLearnCSharp
{
    public class Rectangle : TwoDShape
    {
        public Rectangle(double w, double h) : base(w, h, "прямоугольник") {}
        
        public Rectangle(double w) : base(w, "прямоугольник") {}

        public Rectangle(Rectangle ob) : base(ob) {}
        
        

        public bool IsSquare()
        {
            return (Width == Height);
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
