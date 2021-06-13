using System;

namespace BasicLearnCSharp
{
    static class SDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходное значение переменной StaticDemo.Val равно: " + StaticDemo.Val);

            StaticDemo.Val = 8;
            Console.WriteLine("Текущее значение переменной StaticDemo.Val равно: " + StaticDemo.Val);
            Console.WriteLine("StaticDemo.ValDiv2(): " + StaticDemo.ValDiv2());
            
        }
    }
}
