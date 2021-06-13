using System;

namespace BasicLearnCSharp
{
    public class MyClass
    {
        private int alpha, beta;

        public MyClass(int i, int j)
        {
            alpha = i;
            beta = j;
        }

        public bool SameAs(MyClass ob)
        {
            if ((ob.alpha == alpha) & (ob.beta == beta))
                return true;
            else return false;
        }

        public void Copy(MyClass ob)
        {
            alpha = ob.alpha;
            beta = ob.beta;
        }

        public void Show()
        {
            Console.WriteLine("alpha: {0}, betta: {1}", alpha, beta);
        }
    }
}
