using System;

namespace Basic_Learn_Csharp
{
    class Rect
    {
        public int Width;
        public int Height;

        public Rect(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public int Area()
        {
            return Width * Height;
        }
    }
}
