using System;

namespace LearnCSharp
{
    public class MeClass<T> : IMyContraVarGenIF<T>
    {
        public void Show(T x)
        {
            Console.WriteLine(x);
        }
    }
}
