using System;

namespace LearnCSharp
{
    delegate string StrMod(string s);

    static class UseStatementLambdas
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
            
            StrMod strOp = ReplaceSpace; 
            string str;

            str = strOp("Это простой тест.");
            Console.WriteLine("Результирущая строка: " + str);
            Console.WriteLine();
            
            strOp = RemoveSpace; 
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирущая строка: " + str);
            Console.WriteLine();
            
            strOp = Reverce;
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирущая строка: " + str);
        }
    }
}
