using System;

namespace LearnCSharpOther
{
    public class Test : ICloneable
    {
        public X o;
        public int b;

        public Test(int x, int y)
        {
            o = new X(x);
            b = y;
        }

        public void Show(string name)
        {
            Console.Write("Значения объекта " + name + ": ");
            Console.WriteLine("o.a: {0}, b: {1}", o.a, b);
        }

        public object Clone()
        {
            Test temp = new Test(o.a, b);
            return temp;
        }
    }
}
