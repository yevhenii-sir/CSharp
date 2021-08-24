using System;
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

            var array = inter.SelectMany(inner => inner.Select(innerInner => innerInner));
            
            Console.WriteLine(String.Join(" ", array));
        }
    }
}

/*

1 2 3 4 5 6 7 8 9

*/

