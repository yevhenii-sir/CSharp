using System;
using Exercise.Details;
using Exercise.Professions;
using Exercise.Vehicles;

namespace Exercise
{
    static class CarsDemo
    {
        static void Main(string[] args)
        {
            Driver[] drivers =
            {
                new Driver("Алекс Иванов Сергеев", 25, 7),
                new Driver("Сергей Антончук Сергеев", 40, 16)
            };

            Engine[] engines =
            {
                new Engine(286, "Audi"),
                new Engine(368, "MAN"),
                new Engine(490, "Corvette")
            };

            Car[] cars =
            {
                new Car("A8", "седан", 2680.0,
                    drivers[0], engines[0]),
                new Lorry(30, "TGS", "грузовой автомобиль",
                    19000, drivers[1], engines[1]),
                new SportCar(306, "с8", "спорткар",
                    1530, drivers[0], engines[1])
            };

            foreach (var car in cars)
            {
                Console.WriteLine(car + "\n");
            }
        }
    }
}
