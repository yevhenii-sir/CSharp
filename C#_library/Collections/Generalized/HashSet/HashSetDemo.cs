using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class HashSetDemo
    {
        static void Show(string msg, HashSet<char> set)
        {
            Console.Write(msg);
            foreach (var ch in set)
                Console.Write(ch + " ");
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            HashSet<char> setA = new HashSet<char>();
            HashSet<char> setB = new HashSet<char>();

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
            
            setA.ExceptWith(setB);
            Show("Содержимое множества setA после вычитания из множества setB: ", setA);
        }
    }
}

/*
 
Исходное содержимое множества setA: A B C 
Исходное содержимое множества setB: C D E 
Содержимое множества setA после разноименности со множеством setB: A B D E 
Содержимое множества setA после объединения со множеством SetB: A B D E C 
Содержимое множества setA после вычитания из множества setB: A B 

*/


