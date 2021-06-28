using System;

namespace LearnCSharpException.Exceptions
{
    public class ExceptA : Exception
    {
        public ExceptA (string str) : base(str) {}

        public override string ToString()
        {
            return Message;
        }
    }
}
