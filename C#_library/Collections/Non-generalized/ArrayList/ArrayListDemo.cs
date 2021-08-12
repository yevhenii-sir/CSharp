using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            
            Console.WriteLine("Исходное количество элементов: " + al.Count + '\n');
            Console.WriteLine("Добавить 6 елементов");

            al.Add('C');
            al.Add('A');
            al.Add('E');
            al.Add('B');
            al.Add('D');
            al.Add('F');
            
            Console.WriteLine("Kоличество элементов: " + al.Count + '\n');
            Console.WriteLine("Текущее содержимое: " + String.Join(" ", al.ToArray()) + '\n');
            
            Console.WriteLine("Удалить 2 элемента");
            al.Remove('F');
            al.Remove('A');
            Console.WriteLine("Kоличество элементов: " + al.Count + '\n');
            Console.WriteLine("Текущее содержимое: " + String.Join(" ", al.ToArray()) + '\n');

            for (int i = 0; i < 20; i++)
                al.Add((char)('a' + i));
            Console.WriteLine("Текущая емкость: " + al.Capacity);
            Console.WriteLine("Количество елементов после добавления 20 новых: " + al.Count);
            Console.WriteLine("Текущее содержимое: " + String.Join(" ", al.ToArray()) + '\n');
            
            Console.WriteLine("Изменить три первых элемента");
            al[0] = 'X';
            al[1] = 'Y';
            al[2] = 'Z';
            Console.WriteLine("Текущее содержимое: " + String.Join(" ", al.ToArray()) + '\n');
        }
    }
}

/*

Исходное количество элементов: 0

Добавить 6 елементов
Kоличество элементов: 6

Текущее содержимое: C A E B D F

Удалить 2 элемента
Kоличество элементов: 4

Текущее содержимое: C E B D

Текущая емкость: 32
Количество елементов после добавления 20 новых: 24
Текущее содержимое: C E B D a b c d e f g h i j k l m n o p q r s t

Изменить три первых элемента
Текущее содержимое: X Y Z D a b c d e f g h i j k l m n o p q r s t

*/
