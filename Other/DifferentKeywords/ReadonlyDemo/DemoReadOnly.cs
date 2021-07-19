using System;

namespace LearnCSharpOther
{
    static class DemoReadOnly
    {
        static void Main(string[] args)
        {
            int[] source = new int[MyClass.SIZE];
            int[] target = new int[MyClass.SIZE];

            for (int i = 0; i < MyClass.SIZE; i++)
                source[i] = i;

            foreach (var i in source)
                Console.Write(i + " ");
            Console.WriteLine();

            for (int i = MyClass.SIZE - 1, j = 0; i > 0; i--, j++)
                target[j] = source[i];

            foreach (var i in target)
                Console.Write(i + " ");

            //MyClass.SIZE = 100; //Нельзя изменять поле с типом readonly
        }
    }
}

/*

0 1 2 3 4 5 6 7 8 9 
9 8 7 6 5 4 3 2 1 0 

 */

