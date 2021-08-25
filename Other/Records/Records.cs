using System;

namespace LearnCShOther
{
    public record Person(string Name, int Age);
    
    static class Record
    {
        static void Main(string[] args)
        {
            var person = new Person("Tom", 36);
            Console.WriteLine(person.Name);

            var (userName, userAge) = person;
            
            Console.WriteLine(userAge);
            Console.WriteLine(userName);
        }
    }
}
