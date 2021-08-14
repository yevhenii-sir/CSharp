using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class GenDictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            
            dict.Add("Батлер, Джон", 73000);
            dict.Add("Шварц, Capa", 59000);
            dict.Add("Пайк, Томас", 45000);
            dict.Add("Фрэнк, Эд", 99000);

            //ICollection<string> c = dict.Keys;

            foreach (var str in dict.Keys)
                Console.WriteLine($"{str}, зарплата: {dict[str]:C}");
        }
    }
}

/*

Батлер, Джон, зарплата: $73,000.00
Шварц, Capa, зарплата: $59,000.00
Пайк, Томас, зарплата: $45,000.00
Фрэнк, Эд, зарплата: $99,000.00

*/
