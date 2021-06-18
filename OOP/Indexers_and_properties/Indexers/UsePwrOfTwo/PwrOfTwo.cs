using System;

namespace BasicLearnCSharp
{
    public class PwrOfTwo
    {
        public int this[int index]
        {
            get
            {
                if ((index >= 0) & (index < 16))
                {
                    return Pwr(index); //or (int)Math.Pow(2, index);
                }
                else return -1;
            }
        }

        private int Pwr(int p)
        {
            int result = 1;

            for (int i = 0; i < p; i++)
            {
                result *= 2;
            }

            return result;
        }
    }
}
