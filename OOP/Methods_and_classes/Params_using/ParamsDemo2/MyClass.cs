using System;

namespace BasicLearnCSharp
{
    public class MyClass
    {
        public void ShowArgs(string msg, params int[] nums)
        {
            Console.Write(msg + ": ");

            foreach (var i in nums)
            {
                Console.Write(i + " ");
            }
            
            Console.WriteLine();
        }
    }
}
