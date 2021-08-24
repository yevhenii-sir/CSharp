using System;

namespace LearnCSharpOther
{
    static class ExceptionFilters
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 0;

            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException) when (y == 0 && x == 0)
            {
                Console.WriteLine("Y не должен быть равен 0");
            }
            catch (DivideByZeroException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
