using System;

namespace LearnCSharpOther
{
    static class SortDemo
    {
        static void Main(string[] args)
        {
            int[] nums = {5, 4, 6, 3, 14, 9, 8, 17, 1, 24, -1, 0};
            
            Console.WriteLine("Исходный порядок следования: " + String.Join(" ", nums));
            
            Array.Sort(nums);
            
            Console.WriteLine("Порядок следования после сортировки: " + String.Join(" ", nums));

            int inx = Array.BinarySearch(nums, 14);
            Console.WriteLine("Индекс элемента массива со значением 14: " + inx);
        }
    }
}

/*

Исходный порядок следования: 5 4 6 3 14 9 8 17 1 24 -1 0
Порядок следования после сортировки: -1 0 1 3 4 5 6 8 9 14 17 24
Индекс элемента массива со значением 14: 9

*/
