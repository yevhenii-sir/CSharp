using System;

namespace Basic_Learn_Csharp
{
    class SearchForeach
    {
        static void Main()
        {
            int[] nums = new int[10];
            int val;
            bool found = false;

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            val = 5;

            foreach (int x in nums)
            {
                if (x == val)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Значение найдено!");
            }
        }
    }
}