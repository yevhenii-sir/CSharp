using System;

namespace LearnCSharpException
{
    static class NREDemo
    {
        static void Main(string[] args)
        {
            X p = new X(10);
            X q = null;

            int val;

            try
            {
                val = p.Add(q);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Исключение NullReferenceException");
                Console.WriteLine("Исправление ошибки...\n");

                q = new X(9);
                val = p.Add(q);
            }
            
            Console.WriteLine("Значение val равно {0}", val);
        }
    }
}



