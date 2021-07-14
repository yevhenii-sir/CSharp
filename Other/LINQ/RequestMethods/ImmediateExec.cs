using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class ImmediateExec
    {
        static void Main(string[] args)
        {
            int[] nums = {1, -2, 3, 0, -4, 5};

            int len = (from n in nums
                where n > 0
                select n).Count();
            //or
            int len2 = (nums.Where(w => w > 0)).Count();

            Console.WriteLine($"Количество положительных значений в масиве nums: (len: {len}, len2: {len2})");
        }
    }
}

/*
 
Количество положительных значений в масиве nums: (len: 3, len2: 3)

*/
