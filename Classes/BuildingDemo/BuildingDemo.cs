using System;

namespace Basic_Learn_Csharp
{
    class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building();
            Building office = new Building();

            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

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