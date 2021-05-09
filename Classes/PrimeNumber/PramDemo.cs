using System;

namespace Basic_Learn_Csharp
{
    class ParamDemo
    {
        static void Main()
        {
            ChkNum ob = new ChkNum();

            for (int i = 2; i < 10; i++)
            {
                if (ob.IsPrime(i)) Console.WriteLine(i + " - простое число.");
                else Console.WriteLine(i + " - непростое число.");  
            }
        }
    }
}