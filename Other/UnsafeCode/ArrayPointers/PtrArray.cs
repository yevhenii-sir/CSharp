using System;

namespace LearnCSharpOther
{
    static class PtrArray
    {
        static unsafe void Main(string[] args)
        {
            int[] nums = new int[10];

            fixed (int* p = &nums[0], p2 = nums)
            {
                if (p == p2)
                    Console.WriteLine("Указатели p и p2 содержат один" +
                                      " и тот же адрес.");
            }
        }
    }
}
