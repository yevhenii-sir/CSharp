using System;

namespace BasicLearnCSharp
{
    public class TwoDShape
    {
        public double Width;
        public double Height;

        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " + 
                              Width + " и " + Height);
        }
    }
}
