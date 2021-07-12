using System;

namespace LearnCSharp
{
    public class StackException : Exception
    {
        public StackException() : base() {}
        public StackException(string str) : base(str) {}
        public StackException(string str, Exception inner) : base(str, inner) {}
        public StackException(System.Runtime.Serialization.SerializationInfo si, 
            System.Runtime.Serialization.StreamingContext sc) : base(si, sc) {}

        public override string ToString()
        {
            return Message;
        }
    }
}
