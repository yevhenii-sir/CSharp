using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class IDicEnumDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("Ken", "555-7756");
            ht.Add("Merry", "555-9876");
            ht.Add("Tom", "555-3456");
            ht.Add("Tod", "555-3452");

            IDictionaryEnumerator etr = ht.GetEnumerator();
            Console.WriteLine("Отобразить информацию с помощю свойства Entry.");
            while (etr.MoveNext())
                Console.WriteLine(etr.Entry.Key + ": " + etr.Entry.Value);
            Console.WriteLine();
            
            Console.WriteLine("Отобразить с помощю свойств Key and Value.");
            etr.Reset();
            while (etr.MoveNext())
                Console.WriteLine(etr.Key + ": " + etr.Value);
        }
    }
}

/*

Отобразить информацию с помощю свойства Entry.
Ken: 555-7756
Tom: 555-3456
Merry: 555-9876
Tod: 555-3452

Отобразить с помощю свойств Key and Value.
Ken: 555-7756
Tom: 555-3456
Merry: 555-9876
Tod: 555-3452 

*/
