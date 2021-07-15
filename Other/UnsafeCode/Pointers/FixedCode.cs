using System;

namespace LearnCSharpOther
{
    class Test
    {
        public int num;

        public Test(int i)
        {
            num = i;
        }
    }

    static class FixedCode
    {
        static unsafe void Main(string[] args)
        {
            Test o = new Test(19);

            fixed (int* p = &o.num)
            {
                Console.WriteLine("Исходное значение переменной o.num: " + *p);

                *p = 10;
                
                Console.WriteLine("Новое значение переменной o.num: " + *p);
            }
        }
    }
}
