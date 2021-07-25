using System;

namespace LearnCSharpOther
{ 
    static class PictureFormatDemo
    {
        static void Main(string[] args)
        {
            double num = 64354.2345;
            
            Console.WriteLine("Формат по умолчанию: " + num);
            Console.WriteLine($"Значение с 2 десятичными разрядами: {num:#.##}");
            Console.WriteLine($"Добавить запятые: {num:#,###.##}");
            Console.WriteLine($"Использовать экспоненциальное представление: {num:#.###e+00}");
            Console.WriteLine($"Значение в тысячах: {num:#0,}");
            
            Console.WriteLine("\nОтобразить по-разному положительные," +
                              "отрицательные и нулевые значения.");
            Console.WriteLine($"{num:#.#;(#.##);0.00}");
            num = -num;
            Console.WriteLine($"{num:#.##;(#.##);0.00}");
            num = 0.0;
            Console.WriteLine($"{num:#.##;(#.##);0.00}");

            num = 0.17;
            Console.WriteLine($"Отобразить в процентах: {num:#%}");
        }
    }
}

/*

Формат по умолчанию: 64354.2345
Значение с 2 десятичными разрядами: 64354.23
Добавить запятые: 64,354.23
Использовать экспоненциальное представление: 6.435e+04
Значение в тысячах: 64

Отобразить по-разному положительные,отрицательные и нулевые значения.
64354.2
(64354.23)
0.00
Отобразить в процентах: 17%

*/
