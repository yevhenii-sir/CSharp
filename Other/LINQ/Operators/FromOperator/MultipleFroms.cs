using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class MultipleFroms
    {
        static void Main(string[] args)
        {
            char[] chrs = {'A', 'B', 'C'};
            char[] chrs2 = {'X', 'Y', 'Z'};

            var pairs = from ch1 in chrs
                from ch2 in chrs2
                select new ChrPair(ch1, ch2);
            
            Console.WriteLine("Все сочетания букв ABC и XYZ: ");
            foreach (var p in pairs) 
                Console.WriteLine($"{p.First} {p.Second}");
        }
    }
}

/*
 
Все сочетания букв ABC и XYZ: 
A X
A Y
A Z
B X
B Y
B Z
C X
C Y
C Z

*/

