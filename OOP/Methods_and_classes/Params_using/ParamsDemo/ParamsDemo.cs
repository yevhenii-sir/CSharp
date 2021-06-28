using System;
using BasicLearnCSharp.Exceptions;

namespace BasicLearnCSharp
{
    static class ConveyorDemo
    {
        static void Main(string[] args)
        {
            Min ob = new Min();

            int min;
            int a = 10, b = 20;

            try
            {
                min = ob.MinVal();
                Console.WriteLine("Наименьшее значение равно " + min);
            }
            catch (LuckOfArgumetsParams e)
            {
                Console.WriteLine(e);
            }

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

/*

Аргументы отсутствуют!
Наименьшее значение равно 10
Наименьшее значение равно -1
Наименьшее значение равно 3
Наименьшее значение равно 8

*/
