using System;

namespace Exercise
{
    public class Person
    {
        private string _fullName;
        private int _age;

        public Person() : this("none", 0) {}

        public Person(string fullName, int age)
        {
            _fullName = fullName;
            _age = (age > 0 & age <= 150) ? age : -1;
        }

        public void Move()
        {
            Console.WriteLine($"Персона с именем {_fullName} перемещаеться. Ему {_age} лет.");
        }

        public void Talk()
        {
            Console.WriteLine($"Персона с именем {_fullName} говорит. Ему {_age} лет.");
        }
    }
}
