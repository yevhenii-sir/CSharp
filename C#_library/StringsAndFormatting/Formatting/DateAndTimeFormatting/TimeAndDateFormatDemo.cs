using System;

namespace LearnCSharpOther
{ 
    static class TimeAndDateFormatDemo
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine($"Формат d: {dt:d}");
            Console.WriteLine($"Формат D: {dt:D}");
            
            Console.WriteLine($"\nФормат t: {dt:t}");
            Console.WriteLine($"Формат T: {dt:T}");
            
            Console.WriteLine($"\nФормат f: {dt:f}");
            Console.WriteLine($"Формат F: {dt:F}");
            
            Console.WriteLine($"\nФормат g: {dt:g}");
            Console.WriteLine($"Формат G: {dt:G}");
            
            Console.WriteLine($"\nФормат M: {dt:M}");
            
            Console.WriteLine($"\nФормат o: {dt:o}");
            Console.WriteLine($"Формат O: {dt:O}");
            
            Console.WriteLine($"\nФормат R: {dt:R}");
            
            Console.WriteLine($"\nФормат s: {dt:s}");
            
            Console.WriteLine($"\nФормат u: {dt:u}");
            Console.WriteLine($"Формат U: {dt:U}");
            
            Console.WriteLine($"\nФормат Y: {dt:Y}");
        }
    }
}

/*

Формат d: 7/25/2021
Формат D: Sunday, July 25, 2021

Формат t: 12:54 PM
Формат T: 12:54:56 PM

Формат f: Sunday, July 25, 2021 12:54 PM
Формат F: Sunday, July 25, 2021 12:54:56 PM

Формат g: 7/25/2021 12:54 PM
Формат G: 7/25/2021 12:54:56 PM

Формат M: July 25

Формат o: 2021-07-25T12:54:56.5259463+03:00
Формат O: 2021-07-25T12:54:56.5259463+03:00

Формат R: Sun, 25 Jul 2021 12:54:56 GMT

Формат s: 2021-07-25T12:54:56

Формат u: 2021-07-25 12:54:56Z
Формат U: Sunday, July 25, 2021 9:54:56 AM

Формат Y: July 2021

*/
