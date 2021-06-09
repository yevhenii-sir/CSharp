using System;

namespace BasicLearnCSharp
{
    static class RevStrDemo
    {
        static void Main(string[] args)
        {
            string s = "Это тест";
            RevStr rsOb = new RevStr();
            
            Console.WriteLine("Исходная строка: " + s);

            Console.Write("Перевернутая строка: ");
            rsOb.DisplayRev(s);
            
            Console.WriteLine();
        }
    }
}
