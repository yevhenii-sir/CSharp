using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class GenListDemo
    {
        static void Main(string[] args)
        {
            List<char> lst = new List<char>();
            
            Console.WriteLine("Исходное количество элементов: " + lst.Count + '\n');
            Console.WriteLine("Добавить 6 елементов");

            lst.Add('C');
            lst.Add('A');
            lst.Add('E');
            lst.Add('B');
            lst.Add('D');
            lst.Add('F');
            
            Console.WriteLine("Kоличество элементов: " + lst.Count + '\n');
            Console.WriteLine("Текущее содержимое: " + String.Join(" ", lst) + '\n');
            
            Console.WriteLine("Удалить 2 элемента");
            lst.Remove('F');
            lst.Remove('A');
            Console.WriteLine("Kоличество элементов: " + lst.Count + '\n');
            Console.WriteLine("Текущее содержимое: " + String.Join(" ", lst) + '\n');

            for (int i = 0; i < 20; i++)
                lst.Add((char)('a' + i));
            Console.WriteLine("Текущая емкость: " + lst.Capacity);
            Console.WriteLine("Количество елементов после добавления 20 новых: " + lst.Count);
            Console.WriteLine("Текущее содержимое: " + String.Join(" ", lst) + '\n');
            
            Console.WriteLine("Изменить три первых элемента");
            lst[0] = 'X';
            lst[1] = 'Y';
            lst[2] = 'Z';
            Console.WriteLine("Текущее содержимое: " + String.Join(" ", lst) + '\n');
        }
    }
}


