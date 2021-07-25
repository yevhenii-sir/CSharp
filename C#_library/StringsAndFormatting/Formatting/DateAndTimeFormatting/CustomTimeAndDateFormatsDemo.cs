using System;

namespace LearnCSharpOther
{ 
    static class CustomTimeAndDateFormatsDemo
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine($"Время: {dt:hh:mm tt}");
            Console.WriteLine($"Время в 24-часовом формате: {dt:HH:mm}");
            Console.WriteLine($"Дата: {dt:ddd MMM dd, yyyy}");
            
            Console.WriteLine($"Эра: {dt:gg}");
            
            Console.WriteLine($"Время с секундами: {dt:HH:mm:ss tt}");
            
            Console.WriteLine($"День месяца в формате m: {dt:m}");
            Console.WriteLine($"Минуты в формате m: {dt:%m}");
        }
    }
}

/*

Время: 01:29 PM
Время в 24-часовом формате: 13:29
Дата: Sun Jul 25, 2021
Эра: AD
Время с секундами: 13:29:43 PM
День месяца в формате m: July 25
Минуты в формате m: 29

*/


