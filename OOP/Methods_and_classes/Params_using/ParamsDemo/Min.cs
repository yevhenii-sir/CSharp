using BasicLearnCSharp.Exceptions;

namespace BasicLearnCSharp
{
    public class Min
    {
        public int MinVal(params int[] nums)
        {
            int m;

            if (nums.Length == 0)
                throw new LuckOfArgumetsParams("Аргументы отсутствуют!");

            m = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < m) m = nums[i];
            }

            return m;
        }
    }
}
