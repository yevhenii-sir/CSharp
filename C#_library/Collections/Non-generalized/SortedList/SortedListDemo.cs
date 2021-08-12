using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            
            sl.Add("здание", "жилое помищение");
            sl.Add("автомашина", "транспортное средство");
            sl.Add("книга", "набор печатаных слов");
            sl.Add("яблоко", "съедобный плод");

            sl["трактор"] = "сельскохозяйственая машина";

            Console.WriteLine("Содержимое списка по индексатору.");
            foreach (var str in sl.Keys)
                Console.WriteLine(str + ": " + sl[str]);
            Console.WriteLine();
            
            Console.WriteLine("Содержимое списка по целочисленным индексам.");
            for (int i = 0; i < sl.Count; i++) 
                Console.WriteLine(sl.GetByIndex(i));
            Console.WriteLine();
            
            Console.WriteLine("Целочисленные индексы элементов списка.");
            foreach (var str in sl.Keys)
                Console.WriteLine(str + ": " + sl.IndexOfKey(str));
        }
    }
}

/*

Содержимое списка по индексатору.
автомашина: транспортное средство
здание: жилое помищение
книга: набор печатаных слов
трактор: сельскохозяйственая машина
яблоко: съедобный плод

Содержимое списка по целочисленным индексам.
транспортное средство
жилое помищение
набор печатаных слов
сельскохозяйственая машина
съедобный плод

Целочисленные индексы элементов списка.
автомашина: 0
здание: 1
книга: 2
трактор: 3
яблоко: 4

*/
