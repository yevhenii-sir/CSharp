using System;

namespace LearnCShOther
{
    static class RelationalAndLogicalPatterns
    {
        static decimal Calculate(decimal sum) => sum switch
        {
            <= 0 => 0,
            < 50000 => sum * 0.05m,
            < 100000 => sum * 0.05m,
            _ => sum * 0.2m
        };

        static string CheckAge(int age) => age switch
        {
            < 1 or > 110 => "Недействительный возраст",
            >= 1 and < 18 => "Доступ запрещен",
            33 => "Вам 33, одуамйтесь...",
            _ => "Доступ разрешен"
        };

        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(-200));
            Console.WriteLine(Calculate(0));
            Console.WriteLine(Calculate(10000));
            Console.WriteLine(Calculate(60000));
            Console.WriteLine(Calculate(200000));
            
            Console.WriteLine("-----------");
            
            Console.WriteLine(CheckAge(200));
            Console.WriteLine(CheckAge(0));
            Console.WriteLine(CheckAge(17));
            Console.WriteLine(CheckAge(18));
            Console.WriteLine(CheckAge(33));
        }
    }
}
