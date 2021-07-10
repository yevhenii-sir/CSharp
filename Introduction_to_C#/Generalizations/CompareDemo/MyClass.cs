using System;

namespace LearnCSharp
{
    public class MyClass : IComparable<MyClass>, IEquatable<MyClass>
    {
        public int Val;
        
        public MyClass (int x) { Val = x; }

        public int CompareTo(MyClass other)
        {
            return Val - other.Val;
        }

        public bool Equals(MyClass other)
        {
            return Val == other.Val;
        }

        public override bool Equals(Object obj)
        {
            if (obj is MyClass)
                return Equals((MyClass) obj);
            return false;
        }

        public override int GetHashCode()
        {
            return Val.GetHashCode();
        }
    }
}
