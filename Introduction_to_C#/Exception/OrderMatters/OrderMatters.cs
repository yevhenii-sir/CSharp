using System;
using LearnCSharpException.Exceptions;

namespace LearnCSharpException
{
    static class OrderMatters
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 3; x++)
            {
                try
                {
                    if (x == 0) throw new ExceptA("Перехват исключения типа ExceptA");
                    else if (x == 1) throw new ExceptB("Перехват исключения типа ExceptB");
                    else throw new Exception();
                }
                catch (ExceptB exc)
                {
                    Console.WriteLine(exc);
                }
                catch (ExceptA exc)
                {
                    Console.WriteLine(exc);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }
        }
    }
}
