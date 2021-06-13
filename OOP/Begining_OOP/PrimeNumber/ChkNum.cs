using System;

namespace Basic_Learn_Csharp
{
    class ChkNum
    {
        public bool IsPrime(int x)
        {
            if (x <= 1) return false;

            for (int i = 2; i <= x / i; i++)
            {
                if ((x % i) == 0) return false;
            }

            return true;
        }

        public int LastComFactor(int a, int b)
        {
            int max;
            if (IsPrime(a) || IsPrime(b)) return 1;

            max = a < b ? a : b;

            for (int i = 2; i <= max / 2; i++)
                if (((a % i) == 0) && ((b % i) == 0)) return i;
            return 1;
        }
    }
}
