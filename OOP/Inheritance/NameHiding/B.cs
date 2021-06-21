using System;

namespace CSharpLearn
{
    public class B : A
    {
        private new int i;

        public B(int b)
        {
            i = b;
        }

        public void Show()
        {
            Console.WriteLine("Член i в производном классе: " + i);
        }
    }
}
