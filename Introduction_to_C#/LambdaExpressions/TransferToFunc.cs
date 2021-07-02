using System;

namespace Exercise
{
    static class Test
    {
        delegate bool IsEqual(int x);
     
        static void Main(string[] args)
        {
            int[] integers = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            int result1 = Sum(integers, x => x > 5);
            Console.WriteLine(result1); //30
            
            int result2 = Sum(integers, x => x % 2 == 0);
            Console.WriteLine(result2); //20

            int result3 = Sum(integers, x => x % 2 != 0);
            Console.WriteLine(result3); //25
        }
 
        private static int Sum (int[] numbers, IsEqual func)
        {
            int result = 0;
            foreach(int i in numbers)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }
    }
}

