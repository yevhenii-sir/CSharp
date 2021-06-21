using System;

namespace BasicLearnCSharp
{
    public class TwoDShape
    {
        private double pri_width;
        private double pri_height;

        public TwoDShape()
        {
            Width = Height = 0.0;
        }

        public TwoDShape(double x)
        {
            Width = Height = x;
        }
        
        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }
        
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
    }
}
