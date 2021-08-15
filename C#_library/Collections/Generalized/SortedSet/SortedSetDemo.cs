using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class SortedSetDemo
    {
        static void Show(string msg, SortedSet<char> set)
        {
            Console.Write(msg);
            foreach (var ch in set)
                Console.Write(ch + " ");
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            SortedSet<char> setA = new SortedSet<char>();
            SortedSet<char> setB = new SortedSet<char>();

            setA.Add('A');
            setA.Add('B');
            setA.Add('C');

            setB.Add('C');
            setB.Add('D');
            setB.Add('E');
            
            Show("Исходное содержимое множества setA: ", setA);
            Show("Исходное содержимое множества setB: ", setB);
            
            setA.SymmetricExceptWith(setB);
            Show("Содержимое множества setA после разноименности со множеством setB: ", setA);
            
            setA.UnionWith(setB);
            Show("Содержимое множества setA после объединения со множеством SetB: ", setA);
            Console.WriteLine($"setA.Min = {setA.Min}, setA.Max = {setA.Max}.");

            setA.ExceptWith(setB);
            Show("Содержимое множества setA после вычитания из множества setB: ", setA);
            
        }
    }
}

/*
 
Исходное содержимое множества setA: A B C 
Исходное содержимое множества setB: C D E 
Содержимое множества setA после разноименности со множеством setB: A B D E 
Содержимое множества setA после объединения со множеством SetB: A B C D E 
setA.Min = A, setA.Max = E.
Содержимое множества setA после вычитания из множества setB: A B 

*/


