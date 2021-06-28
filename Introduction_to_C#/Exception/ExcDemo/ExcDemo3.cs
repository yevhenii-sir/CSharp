using System;

namespace LearnCSharpException
{
    class ExcDemo3
    {
        static void Main(string[] args)
        {
            int[] numer = {4, 8, 16, 32, 64, 128};
            int[] denom = {2, 0, 4, 4, 0, 8};

            for (int i = 0; i < numer.Length; i++) 
            {
                try
                {
                    Console.WriteLine(numer[i] + " / " +
                                      denom[i] + " равно " +
                                      numer[i] / denom[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Делить на нуль нельзя!");
                }
            }
        }
    }
}

