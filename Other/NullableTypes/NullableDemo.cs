using System;

namespace LearnCSharpOther
{
    static class NullableDemo
    {
        static unsafe void Main(string[] args)
        {
            int? count = null;

            if (count.HasValue)
                Console.WriteLine("Переменная cout имеет следующие значение: " + count.Value);
            else 
                Console.WriteLine("У переменной count отсутствует значение.");
            
            count = 100;
            if (count.HasValue)
                Console.WriteLine("Переменная cout имеет следующие значение: " + count.Value);
            else 
                Console.WriteLine("У переменной count отсутствует значение.");
        }
    }
}
