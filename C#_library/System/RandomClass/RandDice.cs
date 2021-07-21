using System;

namespace LearnCSharpOther
{
    static class RandDice
    {
        static void Main(string[] args)
        {
            Random ran = new Random();

            for (int i = 0; i < 3; i++)
            {
                Console.Write(ran.Next(1, 7) + " ");
                Console.WriteLine(ran.Next(1, 7));
            }
        }
    }
}

/*

6 3
6 4
5 2

*/
