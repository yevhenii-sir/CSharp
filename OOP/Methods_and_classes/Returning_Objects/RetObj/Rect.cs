using System;

namespace BasicLearnCSharp
{
    public class Rect
    {
        private int width, height;

        public Rect(int w, int h)
        {
            width = w;
            height = h;
        }

        public int Area()
        {
            return width * height;
        }

        public void Show()
        {
            Console.WriteLine(width + " " + height);
        }

        public Rect Enlarge(int factor)
        {
            return new Rect(width * factor, height * factor);
        }
    }
}
