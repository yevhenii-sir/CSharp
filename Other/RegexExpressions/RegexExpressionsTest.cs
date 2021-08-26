using System;
using System.Text.RegularExpressions;

namespace LearnCSharpOther
{
    static class RegexExpressions
    {
        static void Main(string[] args)
        {
            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";

            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}

/*

тупогуб
тупогубенький
тупа

*/
