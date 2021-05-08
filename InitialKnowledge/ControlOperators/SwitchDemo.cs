using System;

class SwitchDemo
{
    static void Main()
    {
        int i;

        for(i = 0; i < 10; i++)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine("i равно нулю");
                    break;
                case 1:
                    Console.WriteLine("i равно еденице");
                    break;
                case 2:
                    Console.WriteLine("i равно двум");
                    break;
                case 3:
                    Console.WriteLine("i равно трем");
                    break;
                case 4:
                    Console.WriteLine("i равно четырем");
                    break;
                default:
                    Console.WriteLine("i равно или больше пяти");
                    break;
            }
        }
    }
}