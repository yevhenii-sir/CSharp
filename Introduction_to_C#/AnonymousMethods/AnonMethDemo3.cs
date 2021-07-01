using System;

namespace LearnCSharp
{
    delegate int CountIt(int end);
    
    static class AnonMethDemo3
    {
        static void Main(string[] args)
        {
            CountIt count = delegate(int end)
            {
                int sum = 0;
                
                for (int i = 0; i <= end; i++)
                {
                    sum += i;
                    Console.WriteLine(i);
                }

                return sum;
            };

            int result = count(3);
            Console.WriteLine("Сума 3 равна " + result);
            Console.WriteLine();
            
            result = count(5);
            Console.WriteLine("Сума 5 равна " + result);
        }
    }
}
