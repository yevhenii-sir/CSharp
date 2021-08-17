using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class MainClass
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

            Console.WriteLine("-----------------------");
            List<MyClass<int>> listMyClass = new List<MyClass<int>>
            {
                { new MyClass<int>(new int[] { 5, 7, 7 }) },
                { new MyClass<int>(new int[] { 4, 7 }) },
                { new MyClass<int>(new int[] { 4, 7, 8, 1 }) },
                { new MyClass<int>(new int[] { 8 }) },
            };
            
            Console.WriteLine("До сортировки: ");
            foreach (var myClass in listMyClass)
            {
                Console.WriteLine(myClass);
            }
            
            Console.WriteLine("\nПосле сортировки: ");
            
            listMyClass.Sort();
            foreach (var myClass in listMyClass)
            {
                Console.WriteLine(myClass);
            }
        }
    }
}

/*

4 3 6 4 7 9 
Вывести заданое количество елементов с заданой позиции: 6 4 7 
True True False True
-----------------------
До сортировки: 
Элементы масива: 5 7 7
Элементы масива: 4 7
Элементы масива: 4 7 8 1
Элементы масива: 8

После сортировки: 
Элементы масива: 8
Элементы масива: 4 7
Элементы масива: 5 7 7
Элементы масива: 4 7 8 1

*/
