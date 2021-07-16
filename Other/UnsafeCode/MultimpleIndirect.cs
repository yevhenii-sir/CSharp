using System;

namespace LearnCSharpOther
{
    static class MultipleIndirect
    {
        static unsafe void Main(string[] args)
        {
            int x;
            int* p;
            int** q;

            x = 10;
            p = &x;
            q = &p;
            
            Console.WriteLine(**q);
        }
    }
}
