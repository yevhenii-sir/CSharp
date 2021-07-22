using System;

namespace LearnCSharpOther
{
    static class CompareDemo
    {
        static void Main(string[] args)
        {
            string str1 = "alpha";
            string str2 = "Alpha";
            string str3 = "Beta";
            string str4 = "alpha";
            string str5 = "alpha, beta";
            int result;

            result = String.Compare(str1, str2, StringComparison.CurrentCulture);
            Console.Write("Сравнение строк с учетом культурной среды: ");
            Console.WriteLine(str1 + ((result < 0) ? " меньше ": (result > 0) ? " больше " : " равно ") + str2);

            result = String.Compare(str1, str2, StringComparison.Ordinal);
            Console.Write("Порядковое сравнение строк: ");
            Console.WriteLine(str1 + ((result < 0) ? " меньше ": (result > 0) ? " больше " : " равно ") + str2);

            result = String.CompareOrdinal(str1, str2);
            Console.Write("Сравнение строк методом CompareOrdinal(): ");
            Console.WriteLine(str1 + ((result < 0) ? " меньше ": (result > 0) ? " больше " : " равно ") + str2 + '\n');
            
            if (str1 == str4) Console.WriteLine(str1 + " == " + str4);
            
            if (str1 != str3) Console.WriteLine(str1 + " != " + str3);
            if (str1 != str2) Console.WriteLine(str1 + " != " + str2);
            
            Console.WriteLine();

            result = String.Compare(str1, str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Сравнение строк методом Equals() с параметром OrdinalIgnoreCase: ");
            Console.WriteLine(str1 + ((result < 0) ? " меньше ": (result > 0) ? " больше " : " равно ") + str2 + '\n');

            if (String.Compare(str2, 0, str5, 0, 3, StringComparison.CurrentCulture) > 0)
            {
                Console.WriteLine("Сравнение строк с учетом текущей культурной среды:" +
                                  "\n3 первых символа строки " + str2 +
                                  " больше, чем 3 первых символа строки " + str5);
            }
        }
    }
}

/*

Сравнение строк с учетом культурной среды: alpha меньше Alpha
Порядковое сравнение строк: alpha больше Alpha
Сравнение строк методом CompareOrdinal(): alpha больше Alpha

alpha == alpha
alpha != Beta
alpha != Alpha

Сравнение строк методом Equals() с параметром OrdinalIgnoreCase: 
alpha равно Alpha

Сравнение строк с учетом текущей культурной среды:
3 первых символа строки Alpha больше, чем 3 первых символа строки alpha, beta

*/
