using System;

namespace LearnCSharpException
{
    public class ExcTest
    {
        public static void GetException()
        {
            int[] nums = new int[4];
            
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
            }
                
            Console.WriteLine("Не подлежит выводу");
        }
    }
}
