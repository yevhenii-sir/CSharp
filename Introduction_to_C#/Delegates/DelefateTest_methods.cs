using System;

namespace LearnCSharp
{
    delegate string StrMod(string str);

    public class StringOps
    {
        public string ReplaceSpace(string s)
        {
            Console.WriteLine("Замена пробелов дефисами.");
            return s.Replace(' ', '-');
        }

        public string Reverce(string s)
        {
            string temp = "";
            int i, j;

            Console.WriteLine("Обращение строки.");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            {
                temp += s[i];
            }

            return temp;
        }

        public string RemoveSpace(string s)
        {
            string tmp = "";
            int i;

            Console.WriteLine("Удаление пробелов.");
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ') tmp += s[i];
            }

            return tmp;
        }
    }

    class DelegateTest
    {
        static void Main(string[] args)
        {
            StringOps so = new StringOps();

            StrMod strOp = new StrMod(so.ReplaceSpace);
            string str;

            str = strOp("Это простой тест.");
            Console.WriteLine("Результирущая строка: " + str);
            Console.WriteLine();
            
            strOp = so.RemoveSpace;
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирущая строка: " + str);
            Console.WriteLine();
                
            strOp = so.Reverce; 
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирущая строка: " + str);
        }
    }
}
