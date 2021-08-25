using System;

namespace LearnCShOther
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;
        }
    }
    
    static class Deconstructors
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Tomas", Age = 25 };

            (string name, int age) = person;
            
            Console.WriteLine("Name: " + name + ", Age: " + age);
        }
    }
}
