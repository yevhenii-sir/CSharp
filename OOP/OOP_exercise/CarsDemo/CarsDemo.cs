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


/* Результат выполнения программы:
Двигатель:
       Мощность двигателя - 286
       Изготовитель - Audi
Водитель:
       Стаж водителя - 7 лет
       ФИО - Алекс Иванов Сергеев
       Возраст - 25
Модель машины - A8
Класс машины - седан
Вес машины 2 680 кг.

Двигатель:
       Мощность двигателя - 368
       Изготовитель - MAN
Водитель:
       Стаж водителя - 16 лет
       ФИО - Сергей Антончук Сергеев
       Возраст - 40
Модель машины - TGS
Класс машины - грузовой автомобиль
Вес машины 19 000 кг.
Грузоподъемность - 30 т.

Двигатель:
       Мощность двигателя - 368
       Изготовитель - MAN
Водитель:
       Стаж водителя - 7 лет
       ФИО - Алекс Иванов Сергеев
       Возраст - 25
Модель машины - с8
Класс машины - спорткар
Вес машины 1 530 кг.
Максимальная скорость - 306
*/
