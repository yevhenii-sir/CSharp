using System;

namespace Exercise
{
    public abstract class Animal
    {
        public string Food { get; set; }
        
        public string Location { get; set; }

        protected Animal(string food, string location)
        {
            Food = food;
            Location = location;
        }

        public abstract void MakeNoise();

        public abstract void Eat();

        public abstract void Sleep();
    }
}
