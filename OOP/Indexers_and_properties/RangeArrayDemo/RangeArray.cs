using System;

namespace BasicLearnCSharp
{
    public class RangeArray
    {
        private int[] a;
        public int lowerBound { get; private set; }

        public int upperBound { get; private set; }

        public int Length { get; private set; }
        
        public bool Error { get; private set; }

        public RangeArray(int low, int hight)
        {
            hight++;

            if (hight <= low)
            {
                Console.WriteLine("Неверные индексы!");
                hight = 1;
                low = 0;
            }

            a = new int[hight - low];
            Length = hight - low;

            lowerBound = low;
            upperBound = hight;
        }

        public int this[int index]
        {
            get
            {
                if (Ok(index))
                {
                    Error = false;
                    return a[index - lowerBound];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }
            set
            {
                if (Ok(index))
                {
                    Error = false;
                    a[index - lowerBound] = value;
                }
                else Error = true;
            }
        }
        
        private bool Ok(int index)
        {
            return (index >= lowerBound & index <= upperBound);
        }
    }
}
