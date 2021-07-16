using System;

namespace LearnCSharpOther
{
    static class FixedString
    {
        static unsafe void Main(string[] args)
        {
            string str = "это тест";

            fixed (char* p = str)
                for (int i = 0; p[i] != 0; i++)
                    Console.Write(p[i]);
            
            Console.WriteLine();
        }
    }
}
