using System;

namespace LearnCSharpOther
{
    class Person : IDisposable
    {
        public string Name { get; set; }

        public void Dispose()
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
            Person person = null;
            try
            {
                person = new Person();
            }
            finally
            {
                if (person != null)
                {
                    person.Dispose();
                }
            }
            
        }
    }
}
