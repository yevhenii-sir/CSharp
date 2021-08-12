using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class ArrayListToArray
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            
            Console.WriteLine("Cодержимое: " + String.Join(" ", al.ToArray()));

            int[] ia = (int[]) al.ToArray(typeof(int));
            int sum = 0; //ia.Sum();

            for (int i = 0; i < ia.Length; i++)
                sum += ia[i];
            Console.WriteLine("Сума равна: " + sum);
        }
    }
}
