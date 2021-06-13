using System;

namespace BasicLearnCSharp
{
    static class OverloadConsDemo
    {
        static void Main(string[] args)
        {
            XYCoord t1 = new XYCoord();
            XYCoord t2 = new XYCoord(8, 9);
            XYCoord t3 = new XYCoord(t2);
            
            Console.WriteLine("t1.x:, t1.y: "+ t1.x + ", " + t1.y);
            Console.WriteLine("t2.x:, t2.y: "+ t2.x + ", " + t2.y);
            Console.WriteLine("t3.x:, t3.y: "+ t3.x + ", " + t3.y);
        }
    }
}
