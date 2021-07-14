using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class OrderbyDemo2
    {
        static void Main(string[] args)
        {
            Account[] accounts =
            {
                new Account("Том", "Смит", "132CK", 100.23),
                new Account("Том", "Смит", "132CD", 10000.0),
                new Account("Ральф", "Джонс", "436CD", 1923.85),
                new Account("Ральф", "Джонс", "454MM", 987.132),
                new Account("Тед", "Краммер", "897CD", 3223.19),
                new Account("Ральф", "Джонс", "434CK", -123.32),
                new Account("Сара", "Смит", "543MM", 5017.40),
                new Account("Сара", "Смит", "547CD", 34955.79),
                new Account("Сара", "Смит", "843CK", 345.00),
                new Account("Альберт", "Смит", "445CK", 345.00),
                new Account("Бетти", "Краммер", "968MM", 5146.67),
                new Account("Карл", "Смит", "078CD", 15345.99),
                new Account("Дженни", "Джонс", "108CK", 10.98),
            };
            var accInfo = from acc in accounts
                orderby acc.LastName, acc.FirstName, acc.Balance
                select acc;

            string str = "";

            foreach (var account in accInfo)
            {
                if (str != account.FirstName)
                {
                    Console.WriteLine();
                    str = account.FirstName;
                }
                
                Console.WriteLine($"{account.LastName}, {account.FirstName}\tНомер счета: {account.AccountNumber}, {account.Balance,14:C}");
            }
            Console.WriteLine();
        }
    }
}

/*

Джонс, Дженни   Номер счета: 108CK,        10,98 ₴

Джонс, Ральф    Номер счета: 434CK,      -123,32 ₴
Джонс, Ральф    Номер счета: 454MM,       987,13 ₴
Джонс, Ральф    Номер счета: 436CD,     1 923,85 ₴

Краммер, Бетти  Номер счета: 968MM,     5 146,67 ₴

Краммер, Тед    Номер счета: 897CD,     3 223,19 ₴

Смит, Альберт   Номер счета: 445CK,       345,00 ₴

Смит, Карл      Номер счета: 078CD,    15 345,99 ₴

Смит, Сара      Номер счета: 843CK,       345,00 ₴
Смит, Сара      Номер счета: 543MM,     5 017,40 ₴
Смит, Сара      Номер счета: 547CD,    34 955,79 ₴

Смит, Том       Номер счета: 132CK,       100,23 ₴
Смит, Том       Номер счета: 132CD,    10 000,00 ₴

*/
