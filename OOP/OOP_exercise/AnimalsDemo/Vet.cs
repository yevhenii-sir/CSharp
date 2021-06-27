using System;

namespace Exercise
{
    public class Vet
    {
        public void TreatAnimal(Animal animal)
        {
            Console.WriteLine("Еда животного - " + animal.Food + 
                              "\nРасположение животного - " + animal.Location);
        }
    }
}
