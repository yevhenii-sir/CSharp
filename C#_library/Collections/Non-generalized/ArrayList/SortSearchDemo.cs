using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class SortSearchDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(55);
            al.Add(43);
            al.Add(-4);
            al.Add(88);
            al.Add(3);
            al.Add(19);
            
            Console.WriteLine("Исходное содержимое: " + String.Join(" ", al.ToArray()) + '\n');
            
            al.Sort();
            Console.Write("Содержимое после сортировки: ");
            foreach (var i in al)
                Console.Write(i + " ");
            Console.WriteLine('\n');
            
            Console.WriteLine("Индекс елемента 43: " + al.BinarySearch(43));
        }
    }
}
