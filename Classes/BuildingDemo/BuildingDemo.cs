using System;

namespace Basic_Learn_Csharp
{
    class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building();
            int areaPP;

            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            areaPP = house.Area / house.Occupants;

            Console.WriteLine("Дом имеет:\n" +
                house.Floors + " этажа\n" + 
                house.Occupants + " жильца\n" +
                house.Area + " кв. футов общей площади, из них \n" + 
                areaPP + " приходиться на одного человека");
        }
    }
}