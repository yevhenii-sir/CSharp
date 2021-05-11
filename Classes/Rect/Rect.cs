using System;

namespace Basic_Learn_Csharp
{
    class Rect
    {
        public int Width;
        public int Height;

        public Rect(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public int Area()
        {
            return Width * Height;
        }
    }
}
