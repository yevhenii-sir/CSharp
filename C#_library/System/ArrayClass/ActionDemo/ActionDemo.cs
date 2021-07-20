using System;

namespace LearnCSharpOther
{
    static class ActionDemo
    {
        static void Show(MyClass o)
        {
            Console.Write(o.i + " ");
        }

        static void Neg(MyClass o)
        {
            o.i = -o.i;
        }
        
        static void Main(string[] args)
        {
            MyClass[] nums =
            {
                new MyClass(5),
                new MyClass(2),
                new MyClass(3),
                new MyClass(4),
                new MyClass(1),
            };
            
            Console.Write("Содержимое массива nums: ");
            Array.ForEach(nums, Show);
            Console.WriteLine();
            
            Array.ForEach(nums, Neg);
            Console.Write("Содержимое массива nums после отрицания: ");
            Array.ForEach(nums, Show);
            Console.WriteLine();
        }
    }
}

/*

Содержимое массива nums: 5 2 3 4 1 
Содержимое массива nums после отрицания: -5 -2 -3 -4 -1

*/
