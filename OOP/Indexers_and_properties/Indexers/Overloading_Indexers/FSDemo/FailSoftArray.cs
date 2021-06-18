using System;
using System.Runtime.CompilerServices;

namespace BasicLearnCSharp
{
    public class FailSoftArray
    {
        private int[] a;

        public readonly int Length;

        public bool ErrFlag;

        public FailSoftArray(int size)
        {
            a = new int[size];
            Length = size;
        }

        public int this[int index]
        {
            get
            {
                if (Ok(index))
                {
                    ErrFlag = false;
                    return a[index];
                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }
            }
            set
            {
                if (Ok(index))
                {
                    a[index] = value;
                    ErrFlag = false;
                }
                else
                {
                    ErrFlag = true;
                }
            }
        }

        public int this[double idx]
        {
            get
            {
                int index = RoundIndex(idx); //or Convert.ToInt32(Math.Round(idx, MidpointRounding.ToEven))

                if (Ok(index))
                {
                    ErrFlag = false;
                    return a[index];
                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }
            }

            set
            {
                int index = RoundIndex(idx);

                if (Ok(index))
                {
                    ErrFlag = false;
                    a[index] = value;
                }
                else ErrFlag = true;
            }
        }

        private int RoundIndex(double idx)
        {
            if ((idx - (int) idx) < 0.5) return (int) idx;
            else return (int) idx + 1;
        }
        
        private bool Ok(int index)
        {
            return (index >= 0 & index < Length);
        }
    }
}
