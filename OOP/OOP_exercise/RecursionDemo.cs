using System;

namespace Exercise
{
    static class RecursionDemo
    {

        private static void Recurs(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine(a);
                return;
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine(a);
                    Recurs(a - 1, b);
                }
                else
                {
                    Console.WriteLine(a);
                    Recurs(a + 1, b);
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а и б: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------");

            Recurs(a, b);
        }
    }
}
