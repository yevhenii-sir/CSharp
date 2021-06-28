using System;

namespace LearnCSharpException
{
    static class ThrowDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("До гинерирования исключения.");
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Исключение перехвачено.");
            }
            
            Console.WriteLine("После операторов try/catch.");
        }
    }
}

