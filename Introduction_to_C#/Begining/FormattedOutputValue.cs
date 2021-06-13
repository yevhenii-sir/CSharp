using System;

class DisplayOptions
{
    static void Main()
    {
        Console.WriteLine("Число\tКвадрат\tКуб");

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
        }

        Console.WriteLine("---------------\n");

        Console.WriteLine("Деление 10/3 дает: {0:#.##}\n\t20/3: {1:#.###}\n", 10.0/3.0, 20.0/3.0);

        Console.WriteLine("---------------\n");
        decimal balance;

        balance = 12329.09m;
        Console.WriteLine("Вы заработали: {0:### ###.##} грн. или {0:C}", balance);
    }
}