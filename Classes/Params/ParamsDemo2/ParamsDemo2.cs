using System;

namespace BasicLearnCSharp
{
    static class ParamsDemo2
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            
            ob.ShowArgs("Это ряд целых чисел", 1, 2, 3, 4, 5);
            
            ob.ShowArgs("А это еще два целых числа", 17, 20);
        }
    }
}
