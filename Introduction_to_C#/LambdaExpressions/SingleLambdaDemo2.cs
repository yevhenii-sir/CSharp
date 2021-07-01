using System;

namespace LearnCSharp
{
    delegate bool InRange(int low, int high, int v);

    static class SimpleLambdaDemo2
    {
        static void Main(string[] args)
        {
            InRange RangeOk = (low, high, val) => val >= low && val <= high;

            if (RangeOk(1, 5, 3))
                Console.WriteLine("3 находиться в приделах от 1 до 5");
            else
                Console.WriteLine("3 не находиться в приделах от 1 до 5");

            Console.WriteLine(RangeOk(6, 10, 3)
                ? "3 находиться в приделах от 6 до 10"
                : "3 не находиться в приделах от 6 до 10");
        }
    }
}
