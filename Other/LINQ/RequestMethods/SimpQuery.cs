using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class SimpQery
    {
        static void Main(string[] args)
        {
            int[] nums = {1, -2, 3, 0, -4, 5};

            var posNums = nums.Where(n => n > 0).Select(r => r);
            
            Console.WriteLine("Положительные значения из масива nums: " + String.Join(' ', posNums));
        }
    }
}

