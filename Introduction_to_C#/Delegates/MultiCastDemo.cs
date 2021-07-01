using System;

namespace LearnCSharp
{
    delegate void StrMod(ref string str);

    static class MultiCastDemo
    {
        static void ReplaceSpace(ref string s)
        {
            Console.WriteLine("Замена пробелов дефисами.");
            s = s.Replace(' ', '-');
        }

        static void Reverce(ref string s)
        {
            string temp = "";
            int i, j;

            Console.WriteLine("Обращение строки.");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            {
                temp += s[i];
            }

            s = temp;
        }

        static void RemoveSpace(ref string s)
        {
            string tmp = "";
            int i;

            Console.WriteLine("Удаление пробелов.");
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ') tmp += s[i];
            }

            s = tmp;
        }
        
        static void Main(string[] args)
        {
            StrMod strOp;
            StrMod replaceSp = ReplaceSpace;
            StrMod removeSp = RemoveSpace;
            StrMod reverseStr = Reverce;
            string str = "Это простой тест.";

            strOp = replaceSp;
            strOp += reverseStr;

            strOp(ref str);
            Console.WriteLine("Рещультирующая строка: " + str);
            Console.WriteLine();

            strOp -= replaceSp;
            strOp += removeSp;
            str = "Это простой тест.";

            strOp(ref str);
            Console.WriteLine("Рещультирующая строка: " + str);
            Console.WriteLine();
        }
    }
}
