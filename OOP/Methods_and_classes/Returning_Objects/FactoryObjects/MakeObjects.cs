using System;

namespace BasicLearnCSharp
{
    static class MakeObjects
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0, j = 10; i < 10; i++, j--)
            {
                MyClass ob = MyClass.Factory(i, j);
                ob.Show();
            }
            
            Console.WriteLine();
        }
    }
}
