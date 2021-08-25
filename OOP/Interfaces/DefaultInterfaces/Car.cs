using System;

namespace LearnCSharpOther
{
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Driving");
        }
    }
}
