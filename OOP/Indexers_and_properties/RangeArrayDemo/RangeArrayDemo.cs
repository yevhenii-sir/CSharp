using System;

namespace BasicLearnCSharp
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
            RangeArray ra = new RangeArray(-5, 5);
            RangeArray ra2 = new RangeArray(1, 10);
            RangeArray ra3 = new RangeArray(-20, -12);
            
            ShowArr("ra", ra);
            ShowArr("ra2", ra2);
            ShowArr("ra3", ra3);
        }
    }
}
