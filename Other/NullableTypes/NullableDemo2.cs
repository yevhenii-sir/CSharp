using System;

namespace LearnCSharpOther
{
    static class NullableDemo2
    {
        static unsafe void Main(string[] args)
        {
            int? count = null;
            int? result = null;

            int incr = 10;

            result = count + incr;
            if (result.HasValue)
                Console.WriteLine("Переменная cout имеет следующие значение: " + result.Value);
            else 
                Console.WriteLine("У переменной count отсутствует значение.");

            count = 100;
            result = count + incr;
            if (result.HasValue)
                Console.WriteLine("Переменная cout имеет следующие значение: " + result.Value);
            else 
                Console.WriteLine("У переменной count отсутствует значение.");
        }
    }
}
