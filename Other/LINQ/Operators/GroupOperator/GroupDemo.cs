using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class GroupDemo
    {
        static void Main(string[] args)
        {
            string[] websites =
            {
                "hsNameA.com", "hsNameB.net", "hsNameC.net",
                "hsNameD.com", "hsNameE.org", "hsNameF.org",
                "hsNameG.tv", "hsNameH.net", "hsNameI.tv"
            };
            
            var webAdrs = websites.Where(w => w.LastIndexOf('.') != -1)
                .GroupBy(x => x.Substring(x.LastIndexOf('.')));

            foreach (var sites in webAdrs)
            {
                Console.WriteLine("Веб-сайты, сгрупированные по имени домена " + sites.Key);

                foreach (var site in sites) 
                    Console.WriteLine(" " + site);
                Console.WriteLine();
            }
        }
    }
}

/*
 
Веб-сайты, сгрупированные по имени домена .com
 hsNameA.com
 hsNameD.com

Веб-сайты, сгрупированные по имени домена .net
 hsNameB.net
 hsNameC.net
 hsNameH.net

Веб-сайты, сгрупированные по имени домена .org
 hsNameE.org
 hsNameF.org

Веб-сайты, сгрупированные по имени домена .tv
 hsNameG.tv
 hsNameI.tv

*/
