using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class EnumeratorImplDemo
    {
        static void Main(string[] args)
        {
            MyClass me = new MyClass();
            
            Console.WriteLine("Использовать foreach для вывода: ");
            foreach (char ch in me)
                Console.Write(ch + " ");
            Console.WriteLine();
            
            foreach (char ch in me)
                Console.Write(ch + " ");
            Console.WriteLine();
            
            Console.WriteLine("Использовать IEnumerator для вывода: ");
            IEnumerator enumerator = me.GetEnumerator();
            while (enumerator.MoveNext())
                Console.Write(enumerator.Current + " ");
            Console.WriteLine();
            
            enumerator.Reset(); 
            while (enumerator.MoveNext())
                Console.Write(enumerator.Current + " ");
            Console.WriteLine();
        }
    }
}

/*

Использовать foreach для вывода: 
A B C D 
A B C D 
Использовать IEnumerator для вывода: 
A B C D 
A B C D 

*/
