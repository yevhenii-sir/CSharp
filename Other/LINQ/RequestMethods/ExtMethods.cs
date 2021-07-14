using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class ExtMethods
    {
        static void Main(string[] args)
        {
            int[] nums = {3, 1, 2, 5, 4};

            Console.WriteLine("Минимальное значение равно " + nums.Min());
            Console.WriteLine("Максимальное значение равно " + nums.Max());
            
            Console.WriteLine("Первое значение равно " + nums.First());
            Console.WriteLine("Последнее значение равно " + nums.Last());
            
            Console.WriteLine("Сумавное значение равно " + nums.Sum());
            Console.WriteLine("Среднее значение равно " + nums.Average());
            
            if (nums.All(n => n > 0)) 
                Console.WriteLine("Все значения больше нуля.");
            
            if (nums.Any(n => (n % 2) == 0))
                Console.WriteLine("По крайней мере одно значение являеться четным.");
            
            if (nums.Contains(3)) //присутствует ли елемент в масиве
                Console.WriteLine("Масив содержит значение 3.");
        }
    }
}

/*
 
Минимальное значение равно 1
Максимальное значение равно 5
Первое значение равно 3
Последнее значение равно 4
Сумавное значение равно 15
Среднее значение равно 3
Все значения больше нуля.
По крайней мере одно значение являеться четным.
Масив содержит значение 3.

*/
