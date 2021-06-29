using System;

namespace LearnCSharpStreams
{
    public static class ErrOut
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0;
            int result;
            
            Console.Out.WriteLine("Деление на нуль приведет " + 
                                  "к исключительной ситуации.");

            try
            {
                result = a / b;
            }
            catch (DivideByZeroException exc)
            {
                Console.Error.WriteLine(exc.Message);
            }
        }
    }
}
