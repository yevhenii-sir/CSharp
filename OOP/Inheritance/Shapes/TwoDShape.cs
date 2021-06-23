using System;

namespace BasicLearnCSharp
{
    public abstract class TwoDShape
    {
        private double pri_width;
        private double pri_height;

        public TwoDShape()
        {
            Width = Height = 0.0;
            Name = "null";

        }

        public TwoDShape(double x, string n)
        {
            Width = Height = x;
            Name = n;
        }
        
        public TwoDShape(double w, double h, string n)
        {
            Width = w;
            Height = h;
            Name = n;
        }

        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
            Name = ob.Name;
        }
        
        public string Name { get; set; }
        
        public double Width
        {
            get { return pri_width; }
            set { pri_width = (value < 0) ? -value : value; }
        }

        public double Height
        {
            get { return pri_height; }
            set { pri_height = (value < 0) ? -value : value; }
        }

        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " + 
                              Width + " и " + Height);
        }

        public abstract double Area();
    }
}
