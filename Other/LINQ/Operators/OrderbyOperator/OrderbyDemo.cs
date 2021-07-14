using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class OrderbyDemo
    {
        static void Main(string[] args)
        {
            int[] nums = {10, -19, 4, 7, 2, -5, 0};

            var posNums = from n in nums
                orderby n
                select n;
            
            Console.WriteLine("Значения по наростающей: ");
            foreach (var i in posNums) Console.Write(i + " ");
            Console.WriteLine();
            
            var posNumsDesc = from n in nums
                orderby n descending 
                select n;
            
            Console.WriteLine("Значения по убывающей: ");
            Console.WriteLine(String.Join(" ", posNumsDesc));
        }
    }
}

/*

Значения по наростающей: 
-19 -5 0 2 4 7 10 
Значения по убывающей: 
10 7 4 2 0 -5 -19

*/
