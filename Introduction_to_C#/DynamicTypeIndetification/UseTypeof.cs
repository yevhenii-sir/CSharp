using System;
using System.IO;

namespace LearnCSharp
{
    static class UseTypeof
    {
        static void Main(string[] args)
        {
            Type t = typeof(StreamReader);
            
            Console.WriteLine(t.FullName);
            
            if (t.IsClass) Console.WriteLine("Относиться к классу.");
            if (t.IsAbstract) Console.WriteLine("Являеться абстрактным классом.");
            else Console.WriteLine("Является конкретным классом.");
        }
    }
}

