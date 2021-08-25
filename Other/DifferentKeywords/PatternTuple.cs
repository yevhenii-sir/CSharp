using System;

namespace LearnCShOther
{
    static class PatternTuple
    {
        static string GetWelcome(string lang, string daytime, string status) => (lang, daytime, status) switch
        {
            ("english", "morning", _) => "Good morning",
            ("english", "evening", _) => "Good evening",
            ("german", "morning", _) => "Guten Morgen",
            ("german", "evening", _) => "Guten Abend",
            (_, _, "admin") => "Hello, Admin",
            _ => "Здрасьть"
        };

        static void Main(string[] args)
        {
            string message = GetWelcome("english", "evening", "user");
            Console.WriteLine(message);
 
            message = GetWelcome("french", "morning", "admin");
            Console.WriteLine(message);
        }
    }
}
