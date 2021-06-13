using System;

class WhileDemo
{
    static void Main()
    {
        int num = 435679;
        int mag = 0;

        Console.WriteLine("Число: " + num);

        while (num > 0)
        {
            mag++;
            num = num / 10;
        };

        Console.WriteLine("Порядок велечины: " + mag);
    }
}