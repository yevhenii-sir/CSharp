using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class TwoWheres
    {
        static void Main(string[] args)
        {
            int[] nums = {1, -2, 3, -3, 0, -8, 12, 19, 6, 9, 10};

            var posNums = from n in nums
                where n is > 0 and < 10
                select n;
            
            Console.Write("Положительные значения меньше 10: ");

            foreach (var i in posNums) Console.Write(i + " ");
            
            Console.WriteLine();
        }
    }
}
