using System;

namespace LearnCSharpException.Exceptions
{
    public class RangeArrayExceptions : Exception
    {
        public RangeArrayExceptions() : base() {}
        public RangeArrayExceptions(string str) : base(str) {}
        public RangeArrayExceptions(string str, Exception inner) : base (str, inner) {}
        protected RangeArrayExceptions(System.Runtime.Serialization.SerializationInfo si,
            System.Runtime.Serialization.StreamingContext sc) : base(si, sc) {}

        public override string ToString()
        {
            return Message;
        }
    }
}
