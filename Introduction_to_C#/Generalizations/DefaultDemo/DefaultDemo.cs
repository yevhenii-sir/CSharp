using System;

namespace LearnCSharp
{
    static class DefaultDemo
    {
        static void Main()
        {
            Test<MyClass> x = new Test<MyClass>();
            if (x.obj == null)
                Console.WriteLine("Переменная x.obj имеет пустое значение <null>.");

            Test<int> y = new Test<int>();
            
            if (y.obj == 0)
                Console.WriteLine("Переменная y.obj имеет значение 0.");
        }
    }
}

