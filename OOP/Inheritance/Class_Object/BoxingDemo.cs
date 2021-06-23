using System;

namespace CSharpLearn
{
    static class BoxingDemo
    {
        static void Main(string[] args)
        {
            int x;
            x = 10;
            
            Console.WriteLine("Значение x равно: " + x);

            x = Sqr(x);
            
            Console.WriteLine("Значение х в квадрате равно: " + x);
        }

        static int Sqr(object o)
        {
            return (int) o * (int) o;
        }
    }
}
