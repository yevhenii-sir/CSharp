using System;

namespace LearnCSharpCollections
{
    static class ItrDemo3
    {
        static void Main(string[] args)
        {
            MyClass me = new MyClass();

            foreach (char ch in me)
                Console.Write(ch + " ");
            
            Console.WriteLine();
        }
    }
}

/*

A B C D E F G H I J

*/
