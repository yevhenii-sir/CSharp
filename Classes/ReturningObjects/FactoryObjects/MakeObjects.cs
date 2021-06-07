using System;

namespace BasicLearnCSharp
{
    static class MakeObjects
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();

            int i, j;
            for (i = 0, j = 10; i < 10; i++, j--)
            {
                MyClass anotherOb = ob.Factory(i, j);
                anotherOb.Show();
            }
            
            Console.WriteLine();
        }
    }
}
