using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class ToArrayDemo
    {
        static void Main(string[] args)
        {
            int[] nums = {1, -2, 3, 0, -4, 5};

            int[] arr = nums.Where(w => w > 0).ToArray();

            foreach (var i in arr) Console.Write(i + " ");
        }
    }
}

