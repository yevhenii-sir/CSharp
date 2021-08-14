using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class GenSortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList<string, double> sl = new SortedList<string, double>();
            
            sl.Add("Батлер, Джон", 73000);
            sl.Add("Шварц, Capa", 59000);
            sl.Add("Пайк, Томас", 45000);
            sl.Add("Фрэнк, Эд", 99000);

            //ICollection<string> c = sl.Keys;

            foreach (var str in sl.Keys)
                Console.WriteLine($"{str}, зарплата: {sl[str]:C}");
        }
    }
}

/*
 
Батлер, Джон, зарплата: $73,000.00
Пайк, Томас, зарплата: $45,000.00
Фрэнк, Эд, зарплата: $99,000.00
Шварц, Capa, зарплата: $59,000.00

*/
