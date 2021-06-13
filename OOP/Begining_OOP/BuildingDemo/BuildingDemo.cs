using System;

namespace Basic_Learn_Csharp
{
    class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building(2, 2500, 4);
            Building office = new Building(3, 4200, 25);

            Console.WriteLine("Максимальное количество человек в доме, \n" + 
                "если на каждого должно приходиться " + 300 +
                " кв. футов: " + house.MaxOccupant(300));

            Console.WriteLine();

            Console.WriteLine("Максимальное количество человек в доме, \n" +
                "если на каждого должно приходиться " + 300 +
                " кв. футов: " + office.MaxOccupant(300));
        }
    }
}