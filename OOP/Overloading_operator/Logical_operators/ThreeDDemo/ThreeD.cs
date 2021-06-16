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

        public static bool operator true(ThreeD op)
        {
            /*if ((op.x != 0) || (op.y != 0) || (op.z != 0))
            {
                return true;
            }
            else
                return false;
                */

            return (op.x != 0) || (op.y != 0) || (op.z != 0);
        }

        public static bool operator false(ThreeD op)
        {
            /*if ((op.x == 0) && (op.y == 0) && (op.z == 0))
            {
                return true;
            }
            else
            {
                return false;
            }*/
            return (op.x == 0) && (op.y == 0) && (op.z == 0);
        }

        public static ThreeD operator --(ThreeD op)
        {
            ThreeD result = new ThreeD();

            result.x = op.x - 1;
            result.y = op.y - 1;
            result.z = op.z - 1;

            return result;
        }

        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
}
