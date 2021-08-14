using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class GenLinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<char> ll = new LinkedList<char>();
            
            Console.WriteLine("Исходное количество елементов: " + ll.Count);
            Console.WriteLine();
            
            Console.WriteLine("Добавить в список 5 елементов.");
            ll.AddFirst('A');
            ll.AddFirst('B');
            ll.AddFirst('C');
            ll.AddFirst('D');
            ll.AddFirst('E');
            
            Console.WriteLine("Количество елементов в списке: " + ll.Count);
            LinkedListNode<char> node;
            Console.Write("Отобразить содержимое списка по ссылкам: ");
            for (node = ll.First; node != null; node = node.Next)
                Console.Write(node.Value + " ");
            Console.WriteLine('\n');
            
            Console.Write("Отобразить содержимое списка в цикле foreach: ");
            foreach (var ch in ll)
                Console.Write(ch + " ");
            Console.WriteLine('\n');
            
            Console.Write("Следовать по ссылкам в обратном направлении: ");
            for (node = ll.Last; node != null; node = node.Previous)
                Console.Write(node.Value + " ");
            Console.WriteLine('\n');
            
            Console.WriteLine("Удалить 2 елемента из списка.");
            ll.Remove('C');
            ll.Remove('A');
            
            Console.WriteLine("Количество елементов в списке: " + ll.Count);
            Console.Write("Содержимое после удаления елементов: ");
            foreach (var ch in ll)
                Console.Write(ch + " ");
            Console.WriteLine('\n');

            ll.AddLast('X');
            ll.AddLast('Y');
            ll.AddLast('Z');
            
            Console.Write("Содержимое списка после ввода елементов: ");
            foreach (var ch in ll)
                Console.Write(ch + " ");
            Console.WriteLine();
        }
    }
}

/*

Исходное количество елементов: 0

Добавить в список 5 елементов.
Количество елементов в списке: 5
Отобразить содержимое списка по ссылкам: E D C B A 

Отобразить содержимое списка в цикле foreach: E D C B A 

Следовать по ссылкам в обратном направлении: A B C D E 

Удалить 2 елемента из списка.
Количество елементов в списке: 3
Содержимое после удаления елементов: E D B 

Содержимое списка после ввода елементов: E D B X Y Z 

*/


