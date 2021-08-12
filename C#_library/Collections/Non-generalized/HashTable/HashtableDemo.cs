using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class HashtableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            
            ht.Add("здание", "жилое помищение");
            ht.Add("автомашина", "транспортное средство");
            ht.Add("книга", "набор печатаных слов");
            ht.Add("яблоко", "съедобный плод");

            ht["трактор"] = "сельскохозяйственая машина";

            ICollection c = ht.Keys;

            foreach (var str in c)
                Console.WriteLine(str + ": " + ht[str]);
        }
    }
}

/*

здание: жилое помищение
книга: набор печатаных слов
яблоко: съедобный плод
автомашина: транспортное средство
трактор: сельскохозяйственая машина

*/
