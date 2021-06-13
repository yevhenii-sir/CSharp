using System;
using System.Globalization;

namespace BasicLearnCSharp
{
    class StrOps
    {
        static void Main(string[] args)
        {
            string str1 = "Програмировать в .NET лутше всего на С#.";
            string str2 = "Програмировать в .NET лутше всего на С#.";
            string str3 = "Строки в С# весьма эффективны.";
            string strUp, strLow;
            int result, idx;
            
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("Длина строки str1: " + str1.Length);

            strLow = str1.ToLower(CultureInfo.CurrentCulture);
            strUp = str1.ToUpper(CultureInfo.CurrentCulture);
            Console.WriteLine("Вариант строки str1, " + 
                              "набраный строчными буквами: \n"  + strLow);
            Console.WriteLine("Вариант строки str1, " + 
                              "набраный прописными буквами: \n"  + strUp);
            
            Console.WriteLine();
            
            Console.WriteLine("Вывод строки str1 правильно. ");
            for (int i = 0; i < str1.Length; i++)
                Console.Write(str1[i]);
            
            Console.WriteLine();

            if (str1 == str2)
                Console.WriteLine("str1 == str2");
            else
                Console.WriteLine("str1 != str2");
            
            if (str1 == str3)
                Console.WriteLine("str1 == str3");
            else
                Console.WriteLine("str1 != str3");

            result = string.Compare(str3, str1, StringComparison.CurrentCulture);

            if (result == 0)
            {
                Console.WriteLine("Строки str1 и str3 равны");
            }
            else if (result < 0)
            {
                Console.WriteLine("Строка str1 меньше строки str3");
            }
            else Console.WriteLine("Строка str1 больше строки str3");
            
            Console.WriteLine();

            str2 = "Один Два Три Один";

            idx = str2.IndexOf("Один", StringComparison.Ordinal);
            Console.WriteLine("Индекс первого вхождения подстроки <Один>: " + idx);
            idx = str2.LastIndexOf("Один", StringComparison.Ordinal);
            Console.WriteLine("Индекс последнего вхождения подстроки <Один>: " + idx);
        }
    }
}