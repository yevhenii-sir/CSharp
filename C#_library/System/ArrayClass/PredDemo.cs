using System;

namespace LearnCSharpOther
{
    static class PredDemo
    {
        static bool IsNeg(int v)
        {
            return v < 0;
        }
        
        static void Main(string[] args)
        {
            int[] nums = {1, 4, -1, 5, -9};
            Console.WriteLine("Содержимое массива nums: " + String.Join(" ", nums));

            if (Array.Exists(nums, PredDemo.IsNeg)) //или использовать лямбда-фун. x => x < 0
            {
                Console.WriteLine("Массив содержит отрицательное значение.");
                int x = Array.Find(nums, PredDemo.IsNeg); //или использовать лямбда-фун. x => x < 0
                Console.WriteLine("Первое отрицательное значение: " + x);
            }
            else 
                Console.WriteLine("В массиве nums отсутствуют отрицательные значения");
        }
    }
}

/*

Содержимое массива nums: 1 4 -1 5 -9
Массив содержит отрицательное значение.
Первое отрицательное значение: -1

*/
