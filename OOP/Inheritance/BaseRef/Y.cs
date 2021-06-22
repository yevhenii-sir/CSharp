using System;

namespace CSharpLearn
{
    public class Y : X
    {
        public int b;

        public Y(int i, int j) : base(j)
        {
            b = i;
        }

        public void Show()
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
