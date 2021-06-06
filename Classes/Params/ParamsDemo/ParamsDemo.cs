using System;

namespace BasicLearnCSharp
{
    static class ParamsDemo
    {
        static void Main(string[] args)
        {
            Min ob = new Min();

            int min;
            int a = 10, b = 20;

            min = ob.MinVal(a, b);
            Console.WriteLine("Наименьшее значение равно " + min);

            min = ob.MinVal(a, b, -1);
            Console.WriteLine("Наименьшее значение равно " + min);
            
            min = ob.MinVal(18, 23, 3, 14, 25);
            Console.WriteLine("Наименьшее значение равно " + min);

            int[] argums = {45, 67, 34, 9, 112, 8};
            min = ob.MinVal(argums);
            Console.WriteLine("Наименьшее значение равно " + min);
        }
    }
}
