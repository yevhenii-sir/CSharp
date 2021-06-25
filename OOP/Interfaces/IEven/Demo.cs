using System;

namespace LearnCSharpInterface
{
    public class MyClass : IEven
    {
        bool IEven.IsOdd(int x)
        {
            if ((x % 2) != 0) return true;
            else return false;
        }

        public bool IsEven(int x)
        {
            IEven o = this;
            return !o.IsOdd(x);
        }
    }
}
