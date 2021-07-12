using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    class SimpQuery2
    {
        static void Main(string[] args)
        {
            int[] nums = {1, -2, 3, 0, -4, 5};

            var posNums = from n in nums
                where n > 0
                select n;
            
            Console.WriteLine("Положительные значения из масива nums: ");
            foreach (var i in posNums) Console.Write(i + " ");

            Console.WriteLine();

            Console.WriteLine("\nЗадать значение 99 для елемента массива nums[1]: ");
            nums[1] = 99;
            
            Console.WriteLine("Положительные значения из масива nums: ");
            foreach (var i in posNums) Console.Write(i + " ");

            Console.WriteLine();
            
            
        }
    }
}
