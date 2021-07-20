using System;

namespace LearnCSharpOther
{
    public class MyClass : IComparable<MyClass>
    {
        public int i;

        public MyClass(int x)
        {
            i = x;
        }

        public int CompareTo(MyClass v)
        {
            return i - v.i;
        }

        public bool Equals(MyClass v)
        {
            return i == v.i;
        }
    }
}
