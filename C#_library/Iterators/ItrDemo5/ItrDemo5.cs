using System;

namespace LearnCSharpCollections
{
    static class ItrDemo5
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            Console.WriteLine("Возвратить по очереди первые 7 букв: ");
            foreach (char ch in mc.MyItr(7))
                Console.Write(ch + " ");
            Console.WriteLine();
            
            Console.WriteLine("Возвратить по очереди буквы от F до L: ");
            foreach(char ch in mc.MyItr(5, 12))
                Console.Write(ch + " ");
            Console.WriteLine();

        }
    }
}

/*

Возвратить по очереди первые 7 букв: 
A B C D E F G 
Возвратить по очереди буквы от F до L: 
F G H I J K L 

*/
