using System;

namespace BasicLearnCSharp
{
    public class Min
    {
        public int MinVal(params int[] nums)
        {
            int m;

            if (nums.Length == 0)
            {
                Console.WriteLine("Ошибка: Нет аргументов!");
                return 0;
            }

            m = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < m) m = nums[i];
            }

            return m;
        }
    }
}
