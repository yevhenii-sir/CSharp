using System;

namespace LearnCSharpOther
{
    class UnsafeCode
    {
        static unsafe void Main(string[] args)
        {
            int count = 99;
            int* p;

            p = &count;
            
            Console.WriteLine("Исходное значение переменной count: " + *p);

            *p = 10;
            
            Console.WriteLine("Новое значение переменной count: " + *p);
        }
    }
}
