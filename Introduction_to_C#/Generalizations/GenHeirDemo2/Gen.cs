using System;

namespace LearnCSharp
{
    public class Gen<T> : NonGen
    {
        private T ob;

        public Gen(T o, int n) : base(n)
        {
            ob = o;
        }

        public T GetOb()
        {
            return ob;
        }
    }
}
