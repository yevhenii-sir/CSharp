using System;

namespace LearnCSharpOther
{
    static class PartialDemo
    {
        static void Main(string[] args)
        {
            XY xy = new XY(1, 2);
            
            Console.WriteLine(xy.X + " " + xy.Y);
        }
    }
}
