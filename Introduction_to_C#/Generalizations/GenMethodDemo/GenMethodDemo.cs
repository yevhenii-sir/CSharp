using System;

namespace LearnCSharp
{
    static class GenMethodDemo
    {
        static void Main()
        {
            int[] nums = {1, 2, 3};
            int[] nums2 = new int[4];
            
            Console.WriteLine("Содержимое масива nums: " + String.Join(' ', nums));
            ArrayUtils.CopyInsert(99, 2, nums, nums2);
            Console.WriteLine("Содержимое масива nums2: " + String.Join(' ', nums2));

            string[] strs = {"Обобщения", "весьма", "эфективны."};
            string[] strs2 = new string[4];
            
            Console.WriteLine("Содержимое масива strs: " + String.Join(' ', strs));
            ArrayUtils.CopyInsert("в C#", 1, strs, strs2);
            Console.WriteLine("Содержимое масива strs2: " + String.Join(' ', strs2));
            
            //ArrayUtils.CopyInsert(0.01, 2, nums, nums2); //ошибка, первый аргумент double а третий и четвертый int
        }
    }
}

/*

Содержимое масива nums: 1 2 3
Содержимое масива nums2: 1 2 99 3
Содержимое масива strs: Обобщения весьма эфективны.
Содержимое масива strs2: Обобщения в C# весьма эфективны.

 */

