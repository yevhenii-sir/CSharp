using System;

namespace BasicLearnCSharp
{
    static class ObjInitDemo
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass() {Count = 100, Str = "Testing"};
            
            Console.WriteLine(obj.Count + " " + obj.Str);
        }
    }
}
