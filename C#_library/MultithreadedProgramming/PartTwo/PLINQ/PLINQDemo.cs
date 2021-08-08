using System;
using System.Linq;

namespace LearnCSharpMultiThrProgramming
{
    static class PLINQDemo
    {
        static void Main(string[] args)
        {
            int[] data = new int[100_000_000];

            for (int i = 0; i < data.Length; i++) data[i] = i;
            
            data[1000] = -1;
            data[14000] = -2;
            data[15000] = -3;
            data[676000] = -4;
            data[8024540] = -5;
            data[9908000] = -6;

            var negatives = from val in data.AsParallel()
                where val < 0
                select val;
            
            Console.WriteLine(String.Join(" ", negatives));
        }
    }
}

/*

-1 -2 -3 -4 -5 -6

*/
