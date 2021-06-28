using System;

namespace LearnCSharpException
{
    static class FinallyDemo
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                UseFinally.GetException(i);
                Console.WriteLine();
            }
        }
    }
}
