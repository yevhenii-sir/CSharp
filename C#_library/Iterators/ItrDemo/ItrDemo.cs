using System;

namespace LearnCSharpCollections
{
    static class ItrDemo
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
