using System;

class FindRadius
{
    static void Main()
    {
        double r;
        double area;

        area = 10.0;

        r = Math.Sqrt(area / Math.PI); //Math.PI = 3.1416...

        Console.WriteLine("Радиус равен: " + r);
    }
}