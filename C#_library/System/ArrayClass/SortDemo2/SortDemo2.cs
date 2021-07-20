using System;

namespace LearnCSharpOther
{
    static class SortDemo2
    {
        static void Main(string[] args)
        {
            MyClass[] nums =
            {
                new MyClass(5),
                new MyClass(2),
                new MyClass(3),
                new MyClass(4),
                new MyClass(1)
            };
            
            Console.Write("Исходный порядок следования: ");
            foreach (var o in nums)
                Console.Write(o.i + " ");
            Console.WriteLine();
            
            Array.Sort(nums);
            
            Console.Write("Порядок следования после сортировки: ");
            foreach (var o in nums)
                Console.Write(o.i + " ");
            Console.WriteLine();

            MyClass x = new MyClass(2);
            int idx = Array.BinarySearch(nums, x);
            Console.WriteLine("Индекс елемента масива с объектом MyClass(2): " + idx);
        }
    }
}

/*

Исходный порядок следования: 5 2 3 4 1 
Порядок следования после сортировки: 1 2 3 4 5 
Индекс елемента масива с объектом MyClass(2): 1

*/
