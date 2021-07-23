using System;

namespace LearnCSharpOther
{ 
    static class InsRepRevDemo
    {
        static void Main(string[] args)
        {
            string str = "Это тест";
            
            Console.WriteLine("Исходная строка: " + str);

            str = str.Insert(4, "простой ");
            Console.WriteLine(str);

            str = str.Replace("простой", "непростой");
            Console.WriteLine(str);

            str = str.Remove(4, 5);
            Console.WriteLine(str);
        }
    }
}

/*

Исходная строка: Это тест
Это простой тест
Это непростой тест
Это стой тест

*/


