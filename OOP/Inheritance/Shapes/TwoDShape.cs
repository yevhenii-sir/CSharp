using System;

namespace BasicLearnCSharp
{
    public class TwoDShape
    {
        private double pri_width;
        private double pri_height;

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
