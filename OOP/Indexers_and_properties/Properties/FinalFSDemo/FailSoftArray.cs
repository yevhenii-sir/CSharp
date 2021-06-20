namespace BasicLearnCSharp
{
    public class FailSoftArray
    {
        private int[] a;

        public FailSoftArray(int size)
        {
            a = new int[size];
            Length = size;
        }

        public int Length { get; private set; }

        public bool Error { get; private set; }

        public int this[int index]
        {
            get
            {
                if (Ok(index))
                {
                    Error = false;
                    return a[index];
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
                    a[index] = value;
                    Error = false;
                }
                else
                {
                    Error = true;
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
                    Error = false;
                    return a[index];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }

            set
            {
                int index = RoundIndex(idx);

                if (Ok(index))
                {
                    Error = false;
                    a[index] = value;
                }
                else Error = true;
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
