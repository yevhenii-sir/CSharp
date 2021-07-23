using System;

namespace LearnCSharpOther
{ 
    static class SubstringDemo
    {
        static void Main(string[] args)
        {
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            
            Console.WriteLine("Строка str: " + str);
            Console.WriteLine("ToLower(str): " + str.ToLower());

            Console.WriteLine("\nПодстрока str.Substring(15): " + str.Substring(15));
            
            Console.WriteLine("Подстрока str.Substring(0, 15): " + str.Substring(0, 15));

        }
    }
}

/*

Строка str: ABCDEFGHIJKLMNOPQRSTUVWXYZ
ToLower(str): abcdefghijklmnopqrstuvwxyz

Подстрока str.Substring(15): PQRSTUVWXYZ
Подстрока str.Substring(0, 15): ABCDEFGHIJKLMNO

*/


