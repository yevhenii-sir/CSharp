using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LearnCSharpOther
{
    static class ConvertingArray
    {
        static void Main(string[] args)
        {
            int[][] inter = new int[][]
            {
                new int[] { 1, 2, 3 }, 
                new int[] { 4, 5 }, 
                new int[] { 6, 7, 8, 9 }
            };
            Stopwatch stopwatch = Stopwatch.StartNew();
            
            var array = inter.SelectMany(inner => inner.Select(innerInner => innerInner));
            
            stopwatch.Stop();
            Console.WriteLine("Использование LINQ: " + stopwatch.Elapsed.TotalMilliseconds + " мс");
            stopwatch.Restart();
            
            List<int> array2 = new List<int>();
            foreach (var t in inter)
                foreach (var t1 in t)
                    array2.Add(t1);
            
            stopwatch.Stop();
            Console.WriteLine("Использование foreach и List: " + stopwatch.Elapsed.TotalMilliseconds + " мс");

            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine(String.Join(" ", array2));
        }
    }
}

/*

Использование LINQ: 3.153 мс
Использование foreach и List: 0.0822 мс
1 2 3 4 5 6 7 8 9
1 2 3 4 5 6 7 8 9

*/

