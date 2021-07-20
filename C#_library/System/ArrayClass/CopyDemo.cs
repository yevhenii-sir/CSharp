using System;

namespace LearnCSharpOther
{
    static class CopyDemo
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = { 11, 12, 13, 14, 15 };
            int[] source2 = { -1, -2, -3, -4, -5 };
            
            Console.WriteLine("Исходный массив: " + String.Join(" ", source));
            Console.WriteLine("Исходное содержимое целевого массива: " + String.Join(" ", target));
            
            Array.Copy(source, target, source.Length);
            Console.WriteLine("Целевой массив после копирования: " + String.Join(" ", target));
            
            Array.Copy(source2, 2, target, 3, 2);
            Console.WriteLine("Целевой массив после частичного копирования: " + String.Join(" ", target));
        }
    }
}

/*

Исходный массив: 1 2 3 4 5
Исходное содержимое целевого массива: 11 12 13 14 15
Целевой массив после копирования: 1 2 3 4 5
Целевой массив после частичного копирования: 1 2 3 -3 -4

*/
