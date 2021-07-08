using System;

namespace LearnCSharp
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base() {}
        public NotFoundException(string str) : base(str) {}
        public NotFoundException(string str, Exception inner) : base(str, inner) {}
        public NotFoundException(System.Runtime.Serialization.SerializationInfo si,
            System.Runtime.Serialization.StreamingContext sc) : base(si, sc) {}
    }
}
