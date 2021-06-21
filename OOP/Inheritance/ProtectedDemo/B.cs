using System;

namespace ProtectedDemo
{
    public class B
    {
        protected int i, j;

        public void Set(int a, int b)
        {
            i = a;
            j = b;
        }

        public void Show()
        {
            Console.WriteLine(i + " " + j);
        }
    }
}
