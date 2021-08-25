using System;

namespace LearnCShOther
{
    static class SwitchReturnsValue
    {
        static int Select(int a, int b, int op)
        {
            return op switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                _ => throw new ArgumentException("Недопустимый код операции")
            };
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Select(5, 10, 1));
                Console.WriteLine(Select(5, 10, 2));
                Console.WriteLine(Select(5, 10, 3));
                Console.WriteLine(Select(5, 10, 4));
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
