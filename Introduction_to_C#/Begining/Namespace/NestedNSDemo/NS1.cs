using System;

namespace NS1
{
    public class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("Конструирование класса ClassA");
        }
    }

    namespace NS2
    {
        public class ClassB
        {
            public ClassB()
            {
                Console.WriteLine("Конструирование класса ClassA");
            }
        }
    }
}
