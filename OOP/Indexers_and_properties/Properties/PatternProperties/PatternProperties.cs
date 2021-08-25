using System;

namespace LearnCShOther
{
    class Person
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string Language { get; set; }
    }

    static class PatternProperties
    {
        static string GetMessage(Person p) => p switch
        {
            { Language: "english" } => "Hello!",
            { Language: "german", Status: "admin" } => "Hello, admin!",
            { Language: "french" } => "Salut!",
            { Language: var language} => $"Unknown language: {language}",
            null => "null"
        };

        static void Main(string[] args)
        {
            Person pierre = new Person { Language = "french", Status="user", Name = "Pierre"};
            string message = GetMessage(pierre);
            Console.WriteLine(message);
 
            Person tomas = new Person { Language = "german", Status="admin", Name = "Tomas"};
            Console.WriteLine(GetMessage(tomas));
 
            Person pablo = new Person { Language = "spanish", Status = "user", Name = "Pablo"};
            Console.WriteLine(GetMessage(pablo));   
            
            Person bob = null;
            Console.WriteLine(GetMessage(bob));
        }
    }
}
