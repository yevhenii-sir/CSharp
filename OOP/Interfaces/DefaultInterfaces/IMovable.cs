using System;

namespace LearnCSharpOther
{
    public interface IMovable
    {
        void Move()
        {
            Console.WriteLine("Walking");
        }
    }
}
