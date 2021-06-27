using System;

namespace LearnCSharpException
{
    class ExcDemo2
    {
        static void Main(string[] args)
        {
            try
            {
                ExcTest.GetException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс вышел за границы масива!");
            }
            
            Console.WriteLine("После блока перехвата исключения.");
        }
    }
}
