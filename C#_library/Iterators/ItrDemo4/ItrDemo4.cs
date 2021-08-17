using System;

namespace LearnCSharpCollections
{
    static class ItrDemo4
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

A B C D E

*/
