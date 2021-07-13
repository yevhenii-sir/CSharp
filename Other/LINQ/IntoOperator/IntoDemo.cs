using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class IntoDemo
    {
        static void Main(string[] args)
        {
            string[] websites =
            {
                "hsNameA.com", "hsNameB.net", "hsNameC.net",
                "hsNameD.com", "hsNameE.org", "hsNameF.org",
                "hsNameG.tv", "hsNameH.net", "hsNameI.tv"
            };

            var webAddrs = from addr in websites
                where addr.LastIndexOf('.') != -1
                group addr by addr.Substring(addr.LastIndexOf('.'))
                into ws
                where ws.Count() > 2
                select ws;

            Console.WriteLine("Домены верхнего уровня с более чем двумя членами.");
            
            foreach (var sites in webAddrs)
            {
                Console.WriteLine("Содержимое домена " + sites.Key);

                foreach (var site in sites) 
                    Console.WriteLine(" " + site);
                Console.WriteLine();
            }
        }
    }
}

/*
 
Домены верхнего уровня с более чем двумя членами.
Содержимое домена .net
 hsNameB.net
 hsNameC.net
 hsNameH.net

*/

