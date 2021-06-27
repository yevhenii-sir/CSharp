namespace Exercise
{
    public abstract class Shape
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }

        public abstract void Draw();
    }
}
