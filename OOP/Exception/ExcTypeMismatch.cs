using System;

namespace LearnCSharpException
{
    class ExcTypeMismatch
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
                }
                
                Console.WriteLine("Не подлежит выводу");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Индекс вышел за границы масива!");
            }
            
            Console.WriteLine("После блока перехвата исключения.");
        }
    }
}
