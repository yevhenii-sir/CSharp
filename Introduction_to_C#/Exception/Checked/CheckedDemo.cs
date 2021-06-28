using System;

namespace LearnCSharpException
{
    static class ChekedDemo
    {
        static void Main(string[] args)
        {
            byte a, b;
            byte result;

            a = b = 127;
            
            try
            {
                result = unchecked((byte) (a * b));
                Console.WriteLine("Непроверенный на переполнение результат: " + 
                                  result);

                result = checked((byte) (a * b)); //приводит к иск. ситуации
                Console.WriteLine("Проверенный на переполнение результат: " + 
                                  result);
                
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
