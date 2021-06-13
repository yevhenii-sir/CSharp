using System;

class Inches
{
    static void Main()
    {
        long inches, miles;

        miles = 93000000;

        inches = miles * 5280 * 12;

        Console.WriteLine("Растояние до солнца: " +
            inches + " дюймов.");
    }
}