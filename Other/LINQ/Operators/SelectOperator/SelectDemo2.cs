using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class SelectDemo2
    {
        static void Main(string[] args)
        {
            EmailAddress[] addrs =
            {
                new EmailAddress("Герберт", "Herb@HerbSchild.com"),
                new EmailAddress("Том", "Tom@HerbSchild.com"),
                new EmailAddress("Сара", "Sara@HerbSchild.com")
            };

            var eAddrs = from entry in addrs
                select entry.Address;

            foreach (var s in eAddrs)
                Console.WriteLine("  " + s);
        }
    }
}

/*
 
  Herb@HerbSchild.com
  Tom@HerbSchild.com
  Sara@HerbSchild.com

*/

