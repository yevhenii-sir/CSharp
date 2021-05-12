using System;

namespace Basic_Learn_Csharp
{
    class LengthDemo
    {
        static void Main()
        {
            int[] nums = new int[10];

            Console.WriteLine("Длина масива nums равна " + nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i * i;
            }

            Console.Write("Содержимое масива nums: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
        }
    }
}