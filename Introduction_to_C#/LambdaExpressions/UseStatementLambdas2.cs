using System;

namespace LearnCSharp
{
    delegate string StrMod(string s);

    static class UseStatementLambdas2
    {
        static void Main(string[] args)
        {
            StrMod ReplaceSpace = s =>
            {
                Console.WriteLine("Замена пробелов дефисами.");
                return s.Replace(' ', '-');
            };

            StrMod RemoveSpace = s =>
            {
                string tmp = "";
                int i;

                Console.WriteLine("Удаление пробелов.");
                for (i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ') tmp += s[i];
                }

                return tmp;
            };

            StrMod Reverce = s =>
            {
                string temp = "";
                int i, j;

                Console.WriteLine("Обращение строки.");
                for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                {
                    temp += s[i];
                }

                return temp;
            };

            Show(ReplaceSpace, "Это простой тест.");
            Show(RemoveSpace, "Это простой тест.");
            Show(Reverce, "Это простой тест.");
        }

        private static void Show(StrMod func, string s)
        {
            Console.WriteLine("Результирущая строка: " + func(s));
            Console.WriteLine();
        }
    }
}
