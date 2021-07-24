using System;

namespace LearnCSharpOther
{ 
    static class FormatDemo2v2
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0, prod = 1;
            string str;

            for (i = 1; i <= 10; i++)
            {
                sum += i;
                prod *= i;
                str = String.Format("Сумма:{0,3:D} Произведение: {1,8:D}", sum, prod);
                Console.WriteLine(str);
            }
        }
    }
}

/*

Сумма:  1 Произведение:        1
Сумма:  3 Произведение:        2
Сумма:  6 Произведение:        6
Сумма: 10 Произведение:       24
Сумма: 15 Произведение:      120
Сумма: 21 Произведение:      720
Сумма: 28 Произведение:     5040
Сумма: 36 Произведение:    40320
Сумма: 45 Произведение:   362880
Сумма: 55 Произведение:  3628800

*/
