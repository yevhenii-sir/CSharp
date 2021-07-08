using System;

namespace LearnCSharp
{
    public class TwoGen<T, V>
    {
        private T ob1;
        private V ob2;

        public TwoGen(T o1, V o2)
        {
            ob1 = o1;
            ob2 = o2;
        }

        public void ShowTypes()
        {
            Console.WriteLine("К типу Т относится " + typeof(T));
            Console.WriteLine("К типу V относится " + typeof(V));
        }

        public T GetOb1()
        {
            return ob1;
        }

        public V GetOb2()
        {
            return ob2;
        }
    }
}
