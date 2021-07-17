using System;

namespace LearnCSharpOther
{
    partial class XY
    {
        public int X { get; set; }

        partial void Show()
        {
            Console.WriteLine("{0}, {1}", X, Y);
        }
    }
}
