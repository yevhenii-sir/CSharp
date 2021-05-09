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
    }
}
