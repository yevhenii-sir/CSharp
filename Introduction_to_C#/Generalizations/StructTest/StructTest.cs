using System;

namespace LearnCSharp
{
    static class StructTest
    {
        static void Main()
        {
            XY<int> xy = new XY<int>(10, 20);
            XY<double> xy2 = new XY<double>(88.0, 99.0);
            
            Console.WriteLine(xy.X + ", " + xy.Y);
            
            Console.WriteLine(xy2.X + ", " + xy2.Y);
        }
    }
}

