using System;

namespace CSharpLearn
{
    public class B : A
    {
        private new int i;

        public B(int a, int b)
        {
            base.i = a;
            i = b;
        }

        public void Show()
        {
            Console.WriteLine("Член i в базовом классе: " + base.i);
            Console.WriteLine("Член i в производном классе: " + i);
        }
    }
}
