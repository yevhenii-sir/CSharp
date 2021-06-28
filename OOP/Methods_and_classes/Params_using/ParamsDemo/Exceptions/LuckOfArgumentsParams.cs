using System;

namespace BasicLearnCSharp.Exceptions
{
    public class LuckOfArgumetsParams : Exception
    {
        public LuckOfArgumetsParams() : base() {}
        public LuckOfArgumetsParams(string str) : base(str) {}
        public LuckOfArgumetsParams(string str, Exception ln) : base(str, ln) {}
        public LuckOfArgumetsParams(System.Runtime.Serialization.SerializationInfo si,
            System.Runtime.Serialization.StreamingContext sc) : base(si, sc) {}

        public override string ToString()
        {
            return Message;
        }
    }
}
