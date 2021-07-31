using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class SumArray
    {
        private int sum;

        public int SumIt(int[] nums)
        {
            sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                Console.WriteLine("Текущая сума для потока " + Thread.CurrentThread.Name +
                                  " равна " + sum);
                Thread.Sleep(10);
            }

            return sum;
        }
    }
}
