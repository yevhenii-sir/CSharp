using System;

namespace LearnCSharpException
{
    static class RethrowDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Rethrow.GetException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Неисправимая ошибка - программа прервана.");
            }
        }
    }
}
