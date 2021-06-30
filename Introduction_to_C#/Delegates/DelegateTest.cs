using System;

namespace LearnCSharp
{
    delegate string StrMod(string str);

    class DelegateTest
    {
        static string ReplaceSpace(string s)
        {
            Console.WriteLine("Замена пробелов дефисами.");
            return s.Replace(' ', '-');
        }

        static string Reverce(string s)
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

        static string RemoveSpace(string s)
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
        
        static void Main(string[] args)
        {
            //StrMod strOp = new StrMod(ReplaceSpace); 
            StrMod strOp = RemoveSpace; //group transformation
            string str;

            str = strOp("Это простой тест.");
            Console.WriteLine("Результирущая строка: " + str);
            Console.WriteLine();
            
            //strOp = new StrMod(RemoveSpace);
            strOp = RemoveSpace; //group transformation
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирущая строка: " + str);
            Console.WriteLine();
            
            //strOp = new StrMod(Reverce);
            strOp = Reverce; //group transformation
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирущая строка: " + str);
        }
    }
}
