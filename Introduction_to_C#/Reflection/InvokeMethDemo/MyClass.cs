using System;

namespace LearnCSharp
{
    public class MyClass
    {
        private int x;
        private int y;

        public MyClass() : this(0, 0) {}
        
        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }

        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            return (x < i && i < y);
        }

        public void Set(int a, int b)
        {
            Console.Write("В методе Set(int, int).");
            x = a;
            y = b;
            Show();
        }

        public void Set(double a, double b)
        {
            Console.Write("В методе Set(double, double).");
            x = (int) a;
            y = (int) b;
            Show();
        }

        public void Show()
        {
            Console.WriteLine($"Значение x: {x}, значение y: {y}");
        }
    }
}
