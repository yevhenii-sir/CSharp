using System;

namespace BasicLearnCSharp
{
    static class PassOb
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass(4, 5);
            MyClass ob2 = new MyClass(6, 7);
            
            Console.Write("ob1: "); 
            ob1.Show();
            
            Console.Write("ob2: ");
            ob2.Show();

            Console.WriteLine(ob1.SameAs(ob2)
                ? "ob1 и ob2 имеют одинаковое значения."
                : "ob1 и ob2 имеют разные значения.");
            
            Console.WriteLine();
            
            ob1.Copy(ob2);
            
            Console.Write("ob1 после копирования: ");
            ob1.Show();
            
            Console.WriteLine(ob1.SameAs(ob2)
                ? "ob1 и ob2 имеют одинаковое значения."
                : "ob1 и ob2 имеют разные значения.");
        }
    }
}
