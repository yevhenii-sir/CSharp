using System;

namespace LearnCSharpInterface
{
    static class SeriesDemo2
    {
        static void Main(string[] args)
        {
            ByTows ob = new ByTows();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующиее число равно " + ob.Next);
            }
            
            Console.WriteLine("\nНачать с числа 21");
            ob.Next = 21;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующиее число равно " + ob.Next);
            }
        }
    }
}
