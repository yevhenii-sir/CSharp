using System;

class IfDemo
{
    static void Main()
    {
        int a, b, c;

        a = 2;
        b = 3;

        if (a < b) Console.WriteLine("а меньше b");
        if (a == b) Console.WriteLine("Этого никто не увидит!");

        Console.WriteLine();

        c = a - b;

        Console.WriteLine("c содержит -1");
        if (c >= 0) Console.WriteLine("Значение неотрецательно!");
        else Console.WriteLine("Значение отрицательно");

        Console.WriteLine();

        c = b - a;

        Console.WriteLine("c содержит 1");
        if (c >= 0) Console.WriteLine("Значение неотрецательно!");
        if (c < 0) Console.WriteLine("Значение отрицательно");
    }
}