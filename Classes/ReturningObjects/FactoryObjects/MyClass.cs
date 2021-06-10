using System;

namespace BasicLearnCSharp
{
    public class MyClass
    {
        private int a, b;

        public static MyClass Factory(int i, int j)
        {
            MyClass t = new MyClass();

            t.a = i;
            t.b = j;

            return t;
        }

        public void Show()
        {
            Console.WriteLine("a и b: " + a + " " + b);
        }
    }
}
