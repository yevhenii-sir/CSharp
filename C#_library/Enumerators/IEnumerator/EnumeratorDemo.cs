using System;
using System.Collections;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class EnumeratorDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using IEnumerator: ");
            ArrayList list = new ArrayList(1);

            for (int i = 0; i < 10; i++)
                list.Add(i);

            IEnumerator etr = list.GetEnumerator();
            while (etr.MoveNext())
                Console.Write(etr.Current + " ");
            Console.WriteLine();
            
            etr.Reset();
            while (etr.MoveNext())
                Console.Write(etr.Current + " ");
            Console.WriteLine();
            
            Console.WriteLine("Using IEnumerator<T>: ");
            List<int> list2 = new List<int>();
            for (int i = 0; i < 10; i++)
                list2.Add(i);

            IEnumerator<int> etr2 = list2.GetEnumerator();
            while (etr2.MoveNext())
                Console.Write(etr2.Current + " ");
            Console.WriteLine();
            
            etr2.Reset();
            while (etr2.MoveNext())
                Console.Write(etr2.Current + " ");
            Console.WriteLine();
        }
    }
}

/*

Using IEnumerator: 
0 1 2 3 4 5 6 7 8 9 
0 1 2 3 4 5 6 7 8 9 
Using IEnumerator<T>: 
0 1 2 3 4 5 6 7 8 9 
0 1 2 3 4 5 6 7 8 9 

*/
