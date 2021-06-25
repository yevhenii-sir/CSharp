namespace LearnCSharpInterface
{
    public class Primes : ISeries
    {
        private int start;
        private int val;

        public Primes()
        {
            start = 2;
            val = 2;
        }

        public int GetNext()
        {
            int i, j;
            bool isprime;

            val++;

            for (i = val; i < 1000000; i++)
            {
                isprime = true;
                for (j = 2; j <= i / j; j++)
                {
                    if ((i % j) == 0)
                    {
                        isprime = false;
                        break;
                    }
                }

                if (isprime)
                {
                    val = i;
                    break;
                }
            }

            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }
}
