using System;

class WhileDemo
{
    static void Main()
    {
        int num = 198;

        Console.WriteLine("Число: " + num);

        Console.Write("Порядок велечины: ");

        do
        {
            Console.Write(num % 10);
            num = num / 10;
        } while (num > 0);

        Console.WriteLine();
    }
}