using System;

namespace LearnCSharp
{
    delegate string StringOp(string s);

    static class Practice
    {
        static void Main(string[] args)
        {
            StringOp removeSp = delegate(string s)
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
            
            StringOp replaceSp = delegate(string s)
            {
                Console.WriteLine("Замена пробелов дефисами.");
                return s.Replace(' ', '-');
            };
            
            StringOp reverseStr = delegate(string s)
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
            
            Console.WriteLine("Результирущая строка: " + replaceSp("Это простой тест."));
            Console.WriteLine();
            
            Console.WriteLine("Результирущая строка: " + removeSp("Это простой тест."));
            Console.WriteLine();
            
            Console.WriteLine("Результирущая строка: " + reverseStr("Это простой тест."));
            Console.WriteLine();
        }
    }
}
