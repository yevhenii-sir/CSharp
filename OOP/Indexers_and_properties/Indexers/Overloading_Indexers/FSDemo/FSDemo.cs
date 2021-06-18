using System;

namespace BasicLearnCSharp
{
    static class FSDemo
    {
        static void Main(string[] args)
        {
            FailSoftArray fs = new FailSoftArray(5);

            for (int i = 0; i < fs.Length; i++)
                fs[i] = i;
            
            Console.WriteLine("fs[1]: " + fs[1]);
            Console.WriteLine("fs[2]: " + fs[2]);
            Console.WriteLine("fs[1.1]: " + fs[1.1]);
            Console.WriteLine("fs[1.6]: " + fs[1.6]);
        }
    }
}
