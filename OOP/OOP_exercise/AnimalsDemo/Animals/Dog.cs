using System;

namespace Exercise.Animals
{
    public class Dog : Animal
    {
        public bool IsHunting { get; set; }
        
        public Dog(string food, string location, bool isHunting) : base(food, location)
        {
            IsHunting = isHunting;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Гав-гав!");
        }

        public override void Eat()
        {
            Console.WriteLine(((IsHunting) ? "Охотничья " : "") + $"Собака кушает - '{Food}'.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Собака спит.");
        }
    }
}
