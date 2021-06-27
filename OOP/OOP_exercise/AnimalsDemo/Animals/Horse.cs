using System;

namespace Exercise.Animals
{
    public class Horse : Animal
    {
        public bool IsRiding { get; set; }
        
        public Horse(string food, string location, bool isRiding) : base(food, location)
        {
            IsRiding = isRiding;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Иии-ги-ги!");
        }

        public override void Eat()
        {
            Console.WriteLine(((IsRiding) ? "Ездовая " : "") + $"Лошадь кушает - '{Food}'");
        }

        public override void Sleep()
        {
            Console.WriteLine("Лошадь спит.");
        }
    }
}
