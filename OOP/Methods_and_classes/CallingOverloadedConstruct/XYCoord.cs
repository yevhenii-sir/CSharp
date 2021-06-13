using System;
using System.Globalization;

namespace BasicLearnCSharp
{
    public class XYCoord
    {
        public int x, y;

        public XYCoord() : this(0, 0)
        {
            Console.WriteLine("В конструкторе ()");
        }

        public XYCoord(XYCoord obj) : this(obj.x, obj.y)
        {
            Console.WriteLine("В констркукторе (obj)");
        }

        public XYCoord(int i, int j)
        {
            Console.WriteLine("В конструкторе (int, int)");
            x = i;
            y = j;
        }
    }
}
