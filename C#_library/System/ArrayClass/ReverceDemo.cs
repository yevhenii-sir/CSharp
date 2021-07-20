using System;

namespace LearnCSharpOther
{
    static class ReverseDemo
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 3, 4, 5};
            
            Console.WriteLine("Исходный порядок следования: " + String.Join(" ", nums));
            
            Array.Reverse(nums);
            Console.WriteLine("Обратный порядок следования: " + String.Join(" ", nums));
            
            Array.Reverse(nums, 1, 3);
            Console.WriteLine("Частично обращенный порядок следования: " +
                              String.Join(" ", nums));
        }
    }
}

/*

Исходный порядок следования: 1 2 3 4 5
Обратный порядок следования: 5 4 3 2 1
Частично обращенный порядок следования: 5 2 3 4 1

*/
