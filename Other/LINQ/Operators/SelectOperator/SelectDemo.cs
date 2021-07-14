using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class SelectDemo
    {
        static void Main(string[] args)
        {
            double[] nums = {-10.0, 16.4, 12.125, 100.85, -2.2, 25.25, -3.5};

            var sqrRoots = from n in nums
                where n > 0
                select Math.Sqrt(n);

            Console.WriteLine("Квадратные корни положительных значений, \n" +
                              "округленные до двух десятичных цифр: ");
            
            foreach (var r in sqrRoots)
                Console.WriteLine($"{r:#.##}");
        }
    }
}

/*

Квадратные корни положительных значений, 
округленные до двух десятичных цифр: 
4,05
3,48
10,04
5,02

*/
