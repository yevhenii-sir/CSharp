using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class GenSortedDictionaryDemo
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> sDict = new SortedDictionary<string, double>();
            
            sDict.Add("Батлер, Джон", 73000);
            sDict.Add("Шварц, Capa", 59000);
            sDict.Add("Пайк, Томас", 45000);
            sDict.Add("Фрэнк, Эд", 99000);

            //ICollection<string> c = sDict.Keys;

            foreach (var str in sDict.Keys)
                Console.WriteLine($"{str}, зарплата: {sDict[str]:C}");
        }
    }
}

/*
 
Батлер, Джон, зарплата: $73,000.00
Пайк, Томас, зарплата: $45,000.00
Фрэнк, Эд, зарплата: $99,000.00
Шварц, Capa, зарплата: $59,000.00

*/
