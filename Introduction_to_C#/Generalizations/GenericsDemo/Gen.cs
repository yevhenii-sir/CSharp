using System;

namespace LearnCSharp
{
    public class Gen<T>
    {
        private T ob;

        public Gen(T o)
        {
            ob = o;
        }

        public T GetOb()
        {
            return ob;
        }

        public void ShowType()
        {
            Console.WriteLine("К типу Т относиться " + typeof(T));
        }
    }
}
