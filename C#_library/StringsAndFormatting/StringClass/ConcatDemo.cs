using System;

namespace LearnCSharpOther
{
    static class ConcatDemo
    {
        static void Main(string[] args)
        {
            string result = String.Concat("Это ", "тест ", "метода ", "сцепления ",
                "строк ", "из класса ", "String.");

            Console.WriteLine("Результат: " + result);
        }
    }
}

/*

Результат: Это тест метода сцепления строк из класса String.

*/
