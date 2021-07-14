using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class SelectDemo3
    {
        static void Main(string[] args)
        {
            ContactInfo[] addrs =
            {
                new ContactInfo("Герберт", "Herb@HerbSchild.com", "555-1010"),
                new ContactInfo("Том", "Tom@HerbSchild.com", "555-1101"),
                new ContactInfo("Сара", "Sara@HerbSchild.com", "555-0110")
            };

            var emailList = from entry in addrs
                select new EmailAddress(entry.Name, entry.Email);

            foreach (var e in emailList)
                Console.WriteLine($"  {e.Name}: {e.Address}");
            
        }
    }
}

/*
 
  Герберт: Herb@HerbSchild.com
  Том: Tom@HerbSchild.com
  Сара: Sara@HerbSchild.com

*/

