using System;
using System.Linq;
using System.Linq.Expressions;

namespace LearnCSharpLINQ
{
    static class SimpleExpTree
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, bool>>
                isFactorExp = (n, d) => (d != 0) ? (n % d) == 0 : false;

            Func<int, int, bool> IsFactor = isFactorExp.Compile();
            
            if (IsFactor(10, 5))
                Console.WriteLine("Число 5 являеться множителем 10.");

            if (!IsFactor(10, 7))
                Console.WriteLine("Число 7 не является множителем 10.");
            
            Console.WriteLine();
        }
    }
}

