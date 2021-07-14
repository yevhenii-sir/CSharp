using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class ExtMethods2
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 4, 8, 6, 9, 10, 3, 6, 7};
            
            Console.WriteLine("Среднее значение равно " + nums.Average());

            var ltAvg = from n in nums
                let x = nums.Average()
                where n < x
                select n;
            
            Console.WriteLine("Значения меньше среднего: ");
            
            foreach (var i in ltAvg) Console.Write(i + " ");
            
            Console.WriteLine();
        }
    }
}

/*
 
Среднее значение равно 5,6
Значения меньше среднего: 
1 2 4 3 

*/
