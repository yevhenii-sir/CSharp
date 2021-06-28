using System;
using LearnCSharpException.Exceptions;

namespace LearnCSharpException
{
    static class RangeArrayDemo
    {
        private static void ShowArr(string name, RangeArray other)
        {
            Console.WriteLine($"Длина масива {name}: " + other.Length);
            for (int i = other.lowerBound; i < other.upperBound; i++)
            {
                other[i] = i;
            }
            
            Console.Write($"Содержимое масива {name}: ");
            for (int i = other.lowerBound; i < other.upperBound; i++)
            {
                Console.Write(other[i] + " ");
            }
            Console.WriteLine("\n");
        }
        
        static void Main(string[] args)
        {
            try
            {
                RangeArray ra = new RangeArray(-5, 5);
                RangeArray ra2 = new RangeArray(1, 10);

                ShowArr("ra", ra);
                ShowArr("ra2", ra2);
            }
            catch (RangeArrayExceptions exc)
            {
                Console.WriteLine(exc);
            }
            
            Console.WriteLine("Сгенерировать ошибки нарушения границ");

            try
            {
                RangeArray ra3 = new RangeArray(100, -10);
            }
            catch (RangeArrayExceptions exc)
            {
                Console.WriteLine(exc);
            }

            try
            {
                RangeArray ra3 = new RangeArray(-2, 2);

                for (int i = -2; i < 2; i++)
                    ra3[i] = i;
                
                Console.Write("Содержимое массива ra3: ");
                for (int i = -2; i <= 10; i++) 
                    Console.Write(ra3[i] + " ");
            }
            catch (RangeArrayExceptions exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}


/*
 
Длина масива ra: 11
Содержимое масива ra: -5 -4 -3 -2 -1 0 1 2 3 4 

Длина масива ra2: 10
Содержимое масива ra2: 1 2 3 4 5 6 7 8 9 

Сгенерировать ошибки нарушения границ
Нижний индекс не меньше верхнего.
Содержимое массива ra3: -2 -1 0 1 0 Ошибка нарушения границ.

 */

