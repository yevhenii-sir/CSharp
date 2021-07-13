using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class LetDemo
    {
        static void Main(string[] args)
        {
            string[] strs = {"alpha", "beta", "gamma"};

            var chars = from str in strs
                let chrArray = str.ToCharArray()
                from ch in chrArray
                orderby ch
                select ch;
            
            Console.WriteLine("Отдельные символы, отсортированые по порядку: ");

            foreach (var c in chars)
                Console.Write(c + " ");
            
            Console.WriteLine("\n---------------------------\n" +
                              "Приминение оператора group: ");
            
            var charsGroup = from str in strs
                let chrArray = str.ToCharArray()
                from ch in chrArray
                orderby ch
                group ch by str;

            foreach (var str in charsGroup)
            {
                Console.Write($"Слово {str.Key} складается с букв: ");

                foreach (var c in str)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
        }
    }
}

/*
 
Отдельные символы, отсортированые по порядку: 
a a a a a b e g h l m m p t 
---------------------------
Приминение оператора group: 
Слово alpha складается с букв: a a h l p 
Слово beta складается с букв: a b e t 
Слово gamma складается с букв: a a g m m 

*/

