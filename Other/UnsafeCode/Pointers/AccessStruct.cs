using System;

namespace LearnCSharpOther
{
    struct MyStrct
    {
        public int a;
        public int b;

        public int Sum()
        {
            return a + b;
        }
    }

    static class AccessStruct
    {
        static unsafe void Main(string[] args)
        {
            MyStrct o = new MyStrct();
            MyStrct* p = &o;

            p->a = 10;
            p->b = 20;
            
            Console.WriteLine("Сума равна " + p->Sum());
        }
    }
}
