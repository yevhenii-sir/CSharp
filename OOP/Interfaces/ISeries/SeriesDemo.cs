using System;

namespace LearnCSharpInterface
{
    static class SeriesDemo
    {
        static void Main(string[] args)
        {
            ByTows ob = new ByTows();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число равно " + ob.GetNext());
            }
            
            Console.WriteLine("\nСбросить");
            ob.Reset();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число равно " + ob.GetNext());
            }
            
            Console.WriteLine("\nНачать с числа 100");
            ob.SetStart(100);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число равно " + ob.GetNext());
            }
        }
    }
}
