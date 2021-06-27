using System;
using Exercise.Details;
using Exercise.Professions;

namespace Exercise.Vehicles
{
    public class Car
    {
        public string Model { get; set; }

        public string CarClass { get; set; }

        public double Weight { get; set; }

        public Driver Driver { get; set; }

        public Engine Engine { get; set; }

        public Car(string model, string carClass,
            double weight, Driver driver, Engine engine)
        {
            Model = model;
            CarClass = carClass;
            Weight = weight;
            Driver = driver;
            Engine = engine;
        }

        public void Start()
        {
            Console.WriteLine("Поехали");
        }

        public void Stop()
        {
            Console.WriteLine("Останавливаемся");
        }

        public void TurnRight()
        {
            Console.WriteLine("Повоот направо");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Поворот налево");
        }

        public override string ToString()
        {
            return "Двигатель:\n" + Engine +
                   "\nВодитель:\n" + Driver +
                   "\nМодель машины - " + Model +
                   "\nКласс машины - " + CarClass +
                   $"\nВес машины {Weight:### ###.## 'кг.'}";
        }
    }
}
