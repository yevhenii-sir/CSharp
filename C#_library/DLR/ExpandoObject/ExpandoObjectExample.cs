using System;
using System.Collections.Generic;

namespace LearnCSharpOther
{
    static class Program
    {
        static void Main(string[] args)
        {
            dynamic viewBag = new System.Dynamic.ExpandoObject();
            viewBag.Name = "Tom";
            viewBag.Age = 46;
            viewBag.Language = new List<string>() { "english", "german", "french" };
            
            Console.WriteLine($"{viewBag.Name} - {viewBag.Age}");
            foreach (var lang in viewBag.Language)
            {
                Console.WriteLine(lang);
            }

            viewBag.IncrementAge = (Action<int>)(x => viewBag.Age += x);
            viewBag.IncrementAge(6);
            Console.WriteLine($"{viewBag.Name} - {viewBag.Age}");
        }
    }
}
