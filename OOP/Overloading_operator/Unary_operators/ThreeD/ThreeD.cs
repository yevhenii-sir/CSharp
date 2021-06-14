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

        /*public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();

            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;
            
            return result;
        }
        
        public static ThreeD operator -(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();

            result.x = op1.x - op2.x;
            result.y = op1.y - op2.y;
            result.z = op1.z - op2.z;
            
            return result;
        }*/

        public static ThreeD operator -(ThreeD op)
        {
            ThreeD result = new ThreeD();

            result.x = -op.x;
            result.y = -op.y;
            result.z = -op.z;

            return result;
        }

        public static ThreeD operator ++(ThreeD op)
        {
            ThreeD result = new ThreeD();

            result.x = op.x + 1;
            result.y = op.y + 1;
            result.z = op.z + 1;

            return result;
        }
        
        public void Show()
        {
            Console.WriteLine(x + " " + y + " " + z);
        }
    }
}
