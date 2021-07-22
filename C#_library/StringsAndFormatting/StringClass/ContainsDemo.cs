using System;

namespace LearnCSharpOther
{
    static class ContainsDemo
    {
        static void Main(string[] args)
        {
            string str = "C# сочетает эффективность с производительностью.";
            
            if (str.Contains("эффективность"))
                Console.WriteLine("Обнаружена подстрока \"эффективность\".");
            
            if (str.Contains("эффе"))
                Console.WriteLine("Обнаружена подстрока \"эффе\".");
            
            if(!str.Contains("эффективный"))
                Console.WriteLine("Подстрока \"эффективный\" не обнаружена.");
        }
    }
}

/*

Обнаружена подстрока "эффективность".
Обнаружена подстрока "эффе".
Подстрока "эффективный" не обнаружена.

*/
