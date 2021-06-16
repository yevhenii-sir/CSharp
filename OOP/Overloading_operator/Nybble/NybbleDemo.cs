using System;

namespace BasicLearnCSharp
{
    static class NybbleDemo
    {
        static void Main(string[] args)
        {
            Nybble a = new Nybble(1);
            Nybble b = new Nybble(10);
            Nybble c = new Nybble();
            int t;
            
            Console.WriteLine("a: " + (int)a);
            Console.WriteLine("b: " + (int)b);
            
            if (a < b) Console.WriteLine("а меньше b\n");

            c = a + b;
            Console.WriteLine("с после операции с = a + b: " + (int)c);

            a += 5;
            Console.WriteLine("a после операции a += 5: " + (int)a);
            Console.WriteLine();

            t = a * 2 + 3;
            Console.WriteLine("Результат вычесления выражения а * 2 + 3: " + t);
            Console.WriteLine();

            a = 19;
            Console.WriteLine("Результат присваивания a = 19: " + (int)a + "\n");
            
            Console.WriteLine("Управление циклом с помощю объекта Nybble.");
            for (a = 0; a < 10; a++)
            {
                Console.Write((int)a + " ");
            }
            
            Console.WriteLine();
        }
    }
}
