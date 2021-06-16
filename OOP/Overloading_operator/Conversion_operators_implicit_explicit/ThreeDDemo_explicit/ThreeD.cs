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

        public static explicit operator int(ThreeD op1)
        {
            return op1.x * op1.y * op1.z;
        }
        
        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD {x = op1.x + op2.x, y = op1.y + op2.y, z = op1.z + op2.z};

            return result;
        }
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
}
