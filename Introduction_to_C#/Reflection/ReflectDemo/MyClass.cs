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
            x = a;
            y = b;
        }

        public void Set(double a, double b)
        {
            x = (int) a;
            y = (int) b;
        }

        public void Show()
        {
            Console.WriteLine($" x: {x}, y: {y}");
        }
    }
}
