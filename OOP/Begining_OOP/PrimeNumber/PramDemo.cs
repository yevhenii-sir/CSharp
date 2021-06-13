using System;

namespace Basic_Learn_Csharp
{
    class ParamDemo
    {
        static void Main()
        {
            ChkNum ob = new ChkNum();
            int a, b;

            for (int i = 2; i < 10; i++)
            {
                if (ob.IsPrime(i)) Console.WriteLine(i + " - простое число.");
                else Console.WriteLine(i + " - непростое число.");  
            }

            a = 7;
            b = 8;
            Console.WriteLine("Найменьший общий множитель чисел " + a +
                " и " + b + " равен " + ob.LastComFactor(a, b));

            a = 100;
            b = 8;
            Console.WriteLine("Найменьший общий множитель чисел " + a +
                " и " + b + " равен " + ob.LastComFactor(a, b));

            a = 100;
            b = 75;
            Console.WriteLine("Найменьший общий множитель чисел " + a +
                " и " + b + " равен " + ob.LastComFactor(a, b));
        }
    }
}