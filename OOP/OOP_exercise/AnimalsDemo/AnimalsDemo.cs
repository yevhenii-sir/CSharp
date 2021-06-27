using System;
using Exercise.Animals;

namespace Exercise
{
    static class AnimalsDemo
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Cat("рыба", "квартира", false),
                new Dog("курица", "загородный дом", true),
                new Horse("сено", "стайня", true)
            };

            Vet veterinary = new Vet();

            foreach (var animal in animals)
            {
                veterinary.TreatAnimal(animal);

                Console.WriteLine();
            }
            
            animals[0].Sleep();
            
            animals[1].Eat();
            
            animals[2].MakeNoise();
        }
    }
}

/* Результат роботы программы:
Еда животного - рыба
Расположение животного - квартира

Еда животного - курица
Расположение животного - загородный дом

Еда животного - сено
Расположение животного - стайня

Кошка спит.
Охотничья Собака кушает - 'курица'.
Иии-ги-ги!
*/
