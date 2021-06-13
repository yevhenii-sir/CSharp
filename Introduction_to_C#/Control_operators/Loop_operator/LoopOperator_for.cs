using System;

class ForDemo
{
    static void Main()
    {
        int count;
        for (count = 0; count < 5; count++)
            Console.WriteLine("Это подсчет: " + count);
        Console.WriteLine("Готово!");
    }
}