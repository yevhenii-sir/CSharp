using System;
using System.IO;
using Newtonsoft.Json;

namespace LearnCSharpOther
{
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    static class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Евгений", 29);
            Console.WriteLine("Объект создан.");

            using (StreamWriter writer = new StreamWriter("file.json"))
            {
                string json = JsonConvert.SerializeObject(person, Formatting.Indented);
                writer.WriteLine(json);
            }

            using (StreamReader reader = new StreamReader("file.json"))
            {
                string text = reader.ReadToEnd();
                Person newPerson = JsonConvert.DeserializeObject<Person>(text);
                if (newPerson != null) Console.WriteLine(newPerson.Name + " " + newPerson.Age);
            }
        }
    }
}
