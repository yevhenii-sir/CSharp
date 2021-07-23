using System;

namespace LearnCSharpOther
{ 
    static class TrimPadDemo
    {
        static void Main(string[] args)
        {
            string str = "тест";
            
            Console.WriteLine("Исходная строка: " + str);

            str = str.PadLeft(10);
            Console.WriteLine("|" + str + "|");

            str = str.PadRight(20);
            Console.WriteLine("|" + str + "|");

            str = str.Trim();
            Console.WriteLine("|" + str + "|");

            str = str.PadLeft(10, '#');
            Console.WriteLine("|" + str + "|");

            str = str.PadRight(20, '#');
            Console.WriteLine("|" + str + "|");

            str = str.Trim('#'); 
            Console.WriteLine("|" + str + "|");
        }
    }
}

/*

Исходная строка: тест
|      тест|
|      тест          |
|тест|
|######тест|
|######тест##########|
|тест|

*/


