using System;

namespace LearnCSharpOther
{
    static class SplitAndJoinDemo
    {
        static void Main(string[] args)
        {
            string str = "Один на суше, другой на море.";
            char[] seps = {' ', '.', ','};

            string[] parts = str.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Результат разделения строки: ");
            for(int i = 0; i < parts.Length; i++)
                Console.WriteLine(parts[i]);
            
            string whole = String.Join(" | ", parts);
            Console.WriteLine(whole);
        }
    }
}

/*

Результат разделения строки: 
Один
на
суше
другой
на
море
Один | на | суше | другой | на | море

*/
