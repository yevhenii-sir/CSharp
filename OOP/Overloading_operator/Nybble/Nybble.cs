using System;

namespace BasicLearnCSharp
{
    public class Nybble
    {
        private int val;

        public Nybble() : this(0) {}

        public Nybble(int val)
        {
            this.val = val;
            this.val = this.val & 0xF;
        }

        public static Nybble operator +(Nybble op1, Nybble op2)
        {
            Nybble result = new Nybble(op1.val + op2.val);
            //Nybble result = new Nybble {val = (op1.val + op2.val) & 0xF};

            return result;
        }

        public static Nybble operator +(int op1, Nybble op2)
        {
            Nybble result = new Nybble(op1 + op2.val);
            //Nybble result = new Nybble {val = (op1 + op2.val) & 0xF};

            return result;
        }

        public static Nybble operator +(Nybble op1, int op2)
        {
            Nybble result = new Nybble(op1.val + op2);
            //Nybble result = new Nybble {val = (op1.val + op2) & 0xF};

            return result;
        }

        public static bool operator >(Nybble op1, Nybble op2)
        {
            return (op1.val > op2.val);
        }

        public static bool operator <(Nybble op1, Nybble op2)
        {
            return (op1.val < op2.val);
        }

        public static Nybble operator ++(Nybble op)
        {
            Nybble result = new Nybble(op.val + 1);
            //Nybble result = new Nybble {val = (op.val + 1) & 0xF};

            return result;
        }

        public static implicit operator Nybble(int op)
        {
            return new Nybble(op);
        }

        public static implicit operator int(Nybble op)
        {
            return op.val;
        }
        
        public int GetVal()
        {
            return val;
        }
    }
}
