using System;

namespace LearnCSharpOther
{
    class Person
    {
        public string Name { get; set; }

        ~Person()
        {
            Console.Beep();
            Console.WriteLine("Disposed");
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            Test();
            GC.Collect();
            Console.WriteLine("Выход из программы");
        }

        public static void Test()
        {
            Person person = new Person();
        }
    }
}
