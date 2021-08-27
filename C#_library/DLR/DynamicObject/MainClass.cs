using System;
using LearnCShOther;

namespace LearnCSharpOther
{
    static class Program
    {
        static void Main(string[] args)
        {
            dynamic person = new PersonObject();
            person.Name = "Tom";
            person.Age = 23;
            Func<int, int> Incr = (x) =>
            {
                person.Age += x;
                return person.Age;
            };
            person.IncrementAge = Incr;
            
            Console.WriteLine($"{person.Name} - {person.Age}");
            person.IncrementAge(4);
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}
