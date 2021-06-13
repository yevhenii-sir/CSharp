using System;

class FindSmallestFactor
{
    static void Main()
    {
        int factor = 1;
        int num = 1000;

        for (int i = 2; i <= num / i; i++)
        {
            if ((num % i) == 0)
            {
                factor = i;
                break;
            }
        }
        Console.WriteLine("Наименьший множитель числа: " + factor);
    }
}