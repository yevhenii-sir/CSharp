using System;
using LearnCSharpException.Exceptions;

namespace LearnCSharpException
{
    public class RangeArray
    {
        private int[] a;
        public int lowerBound { get; private set; }

        public int upperBound { get; private set; }

        public int Length { get; private set; }

        public RangeArray(int low, int hight)
        {
            hight++;

            if (hight <= low)
            {
                throw new RangeArrayExceptions("Нижний индекс не меньше верхнего.");
            }

            a = new int[hight - low];
            Length = hight - low;

            lowerBound = low;
            upperBound = --hight;
        }

        public int this[int index]
        {
            get
            {
                if (Ok(index))
                {
                    return a[index - lowerBound];
                }
                else
                {
                    throw new RangeArrayExceptions("Ошибка нарушения границ.");
                }
            }
            set
            {
                if (Ok(index))
                {
                    a[index - lowerBound] = value;
                }
                else throw new RangeArrayExceptions("Ошибка нарушения границ.");
            }
        }
        
        private bool Ok(int index)
        {
            return (index >= lowerBound & index <= upperBound);
        }
    }
}

