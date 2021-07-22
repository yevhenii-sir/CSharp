using System;

namespace LearnCSharpOther
{
    static class StringSearchDemo
    {
        static void Main(string[] args)
        {
            string str = "C# обладает эффективными средствами обработки строк.";
            int idx;
            
            Console.WriteLine("Строка str: " + str);

            idx = str.IndexOf('о');
            Console.WriteLine("Индекс первого вхождения символа 'o': " + idx);

            idx = str.LastIndexOf('о');
            Console.WriteLine("Индекс последнего вхождения символа 'o': " + idx);

            idx = str.IndexOf("ми", StringComparison.Ordinal);
            Console.WriteLine("Индекс первого вхождения подстроки \"ми\": " + idx);
            
            idx = str.LastIndexOf("ми", StringComparison.Ordinal);
            Console.WriteLine("Индекс последнего вхождения подстроки \"ми\": " + idx);

            char[] chars = {'а', 'б', 'в'};
            idx = str.IndexOfAny(chars);
            Console.WriteLine("Индекс первого вхожления символов 'а', 'б' или 'в': " + idx);

            if (str.StartsWith("C# обладает", StringComparison.Ordinal))
                Console.WriteLine("Строка str начинается с подстроки \"C# обладает\"");
            
            if(str.EndsWith("строк.", StringComparison.Ordinal))
                Console.WriteLine("Строка str оканчивается подстрокой \"строк.\"");
        }
    }
}

/*

Строка str: C# обладает эффективными средствами обработки строк.
Индекс первого вхождения символа 'o': 3
Индекс последнего вхождения символа 'o': 49
Индекс первого вхождения подстроки "ми": 22
Индекс последнего вхождения подстроки "ми": 33
Индекс первого вхожления символов 'а', 'б' или 'в': 4
Строка str начинается с подстроки "C# обладает"
Строка str оканчивается подстрокой "строк."

*/
