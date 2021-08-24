using System;

namespace LearnCSharpOther
{
    static class PascalTriangl
    {
        static void PascalTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int c = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c + " ");
                    c = c * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            Console.Write("Количество уровней для вывода: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            PascalTriangle(n);
        }
    }
}
