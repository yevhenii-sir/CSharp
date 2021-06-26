using System;
using LearnCSharpInterface;

namespace LearnCSharpStructures
{
    static class StructAssignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Structures-----");
            MyStruct a, b;

            a.x = 10;
            b.x = 20;
            
            Console.WriteLine($"a.x {a.x}, b.x {b.x}");

            a = b;
            b.x = 30;
            
            Console.WriteLine($"a.x {a.x}, b.x {b.x}");
            
            
            Console.WriteLine("-------Class-------");
            MyClass A = new MyClass();
            MyClass B = new MyClass();
            
            A.x = 10;
            B.x = 20;
            
            Console.WriteLine($"a.x {A.x}, b.x {B.x}");

            A = B;
            B.x = 30;
            
            Console.WriteLine($"a.x {A.x}, b.x {B.x}");
        }
    }
}
