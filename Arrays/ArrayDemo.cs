using System;

namespace Basic_Learn_Csharp
{
    class ArrayDemo
    {
        static void Main()
        {
            int[] seample = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                seample[i] = i;
            }

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("seample[" + i + "] = " + seample[i]);
            }
        }
    }
}