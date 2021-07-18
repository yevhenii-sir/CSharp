using System;
using System.Globalization;

namespace LearnCSharpOther
{
    static class DynDemo
    {
        static void Main(string[] args)
        {
            dynamic str;
            dynamic val;

            str = "Это строка";
            val = 10;
            
            Console.WriteLine("Переменная str содержит: " + str);
            Console.WriteLine("Переменная val содержит: " + val + '\n');

            str = str.ToUpper(CultureInfo.CurrentCulture);
            Console.WriteLine("Переменная str теперь содержит: " + str);

            val = val + 2;
            Console.WriteLine("Переменная val теперь содержит: " + val + '\n');

            str = str.ToLower(CultureInfo.CurrentCulture);
            Console.WriteLine("Переменная str содержит: " + str);

            int x = val * 2;
            Console.WriteLine("Переменная х содержит: " + x);
        }
    }
}
