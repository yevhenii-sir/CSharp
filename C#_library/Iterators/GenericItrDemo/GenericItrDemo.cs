using System;

namespace LearnCSharpCollections
{
    static class GenericItrDemo
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 3, 6, 4, 7, 9 };
            MyClass<int> mc = new MyClass<int>(nums);

            foreach (var x in mc)
                Console.Write(x + " ");
            Console.WriteLine();
            
            Console.Write("Вывести заданое количество елементов с заданой позиции: ");
            foreach (var n in mc.MyItr(2, 3))
                Console.Write(n + " ");
            Console.WriteLine();

            bool[] bVals = { true, true, false, true };
            MyClass<bool> mc2 = new MyClass<bool>(bVals);
            
            foreach (var x in mc2)
                Console.Write(x + " ");
            Console.WriteLine();
            
            Console.WriteLine();
        }
    }
}

/*

4 3 6 4 7 9 
Вывести заданое количество елементов с заданой позиции: 6 4 7 
True True False True

*/
