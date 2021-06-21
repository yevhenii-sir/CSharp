namespace BasicLearnCSharp
{
    public class Rectangle : TwoDShape
    {
        public bool IsSquare()
        {
            return (Width == Height);
        }

        public double Area()
        {
            return Width * Height;
        }
    }
}
