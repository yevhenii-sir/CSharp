using System;

namespace LearnCSharpOther
{
    static class PtrArithDemo
    {
        static unsafe void Main(string[] args)
        {
            int x;
            int i;
            double d;

            int* ip = &i;
            double* fp = &d;
            
            Console.WriteLine("int double\n");
            for (x = 0; x < 10; x++)
            {
                Console.WriteLine((uint)(ip) + " " + (uint)(fp));
                ip++;
                fp++;
            }
        }
    }
}
