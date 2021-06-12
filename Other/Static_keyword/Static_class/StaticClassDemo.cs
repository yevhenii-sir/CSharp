using System;

namespace BasicLearnCSharp
{
    static class StaticClassDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обратная величина числа 5 равна: " + NumericFn.Reciprocal(5.0));
            Console.WriteLine("Дробная часть числа 4.234 равна: " + NumericFn.Reciprocal(4.234));
            
            if (NumericFn.IsEven(10)) 
                Console.WriteLine("10 - четное число.");
            
            if (NumericFn.IsEven(5))
                Console.WriteLine("5 - нечетное число.");

            //NumericFn ob = new NumericFn(); Ошибка!
        }
    }
}
