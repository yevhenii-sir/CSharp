using System;

namespace Exercise.Animals
{
    public class Cat : Animal
    {
        public bool IsWild { get; set; }
        
        public Cat(string food, string location, bool isWild) : base(food, location)
        {
            IsWild = isWild;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Мяуу!");
        }

        public override void Eat()
        {
            Console.WriteLine(((IsWild) ? "Дикая " : "") + $"Кошка кушает - '{Food}'.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Кошка спит.");
        }
    }
}
