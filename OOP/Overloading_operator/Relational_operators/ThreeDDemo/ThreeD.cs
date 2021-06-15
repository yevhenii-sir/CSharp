using System;

namespace BasicLearnCSharp
{
    public class ThreeD
    {
        private int x, y, z;
        
        public ThreeD() : this(0, 0, 0) {}

        public ThreeD(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static bool operator <(ThreeD op1, ThreeD op2)
        {
            if (Math.Sqrt(Math.Pow(op1.x, 2) + Math.Pow(op1.y, 2) + Math.Pow(op1.z, 2)) <
                Math.Sqrt(Math.Pow(op2.x, 2) + Math.Pow(op2.y, 2) + Math.Pow(op2.z, 2)))
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator >(ThreeD op1, ThreeD op2)
        {
            if (Math.Sqrt(Math.Pow(op1.x, 2) + Math.Pow(op1.y, 2) + Math.Pow(op1.z, 2)) >
                Math.Sqrt(Math.Pow(op2.x, 2) + Math.Pow(op2.y, 2) + Math.Pow(op2.z, 2)))
            {
                return true;
            }
            else
                return false;
        }

        public void Show()
        {
            Console.WriteLine(x + " " + y + " " + z);
        }
    }
}
