using System;

namespace LearnCSharpOther
{
    static class PtrIndexDemo
    {
        static unsafe void Main(string[] args)
        {
            int[] nums = new int[10];

            Console.WriteLine("Индексирования указателя как масива.");
            fixed (int* p = nums)
            {
                for (int i = 0; i < 10; i++)
                    p[i] = i;

                for (int i = 0; i < 10; i++)
                    Console.WriteLine("p[{0}]: {1} ", i, p[i]);
            }

            Console.WriteLine("\nПриминение арифметических " +
                              "операций над указателями.");

            fixed (int* p = nums)
            {
                for (int i = 0; i < 10; i++)
                    *(p + i) = i; //использование арифметики указателей

                for (int i = 0; i < 10; i++)
                    Console.WriteLine("*p + {0}: {1} ", i, *(p + i));
            }
        }
    }
}
