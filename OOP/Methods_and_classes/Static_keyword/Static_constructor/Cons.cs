using System;

namespace BasicLearnCSharp
{
    public class Cons
    {
        public static int alpha;
        public int beta;

        static Cons()
        {
            alpha = 99;
            Console.WriteLine("В статическом конструкторе.");
        }

        public Cons()
        {
            beta = 100;
            Console.WriteLine("В конструкторе екземпляра.");
        }
    }
}
