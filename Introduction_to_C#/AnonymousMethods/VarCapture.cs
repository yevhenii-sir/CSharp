using System;

namespace LearnCSharp
{
    delegate int CountIt(int end);
    
    static class VarCapture
    {

        static CountIt Counter()
        {
            int sum = 0;
            
            CountIt ctObj = delegate(int end)
            {
                for (int i = 0; i <= end; i++)
                {
                    sum += i;
                    Console.WriteLine(i);
                }

                return sum;
            };

            return ctObj;
        }
        
        static void Main(string[] args)
        {
            CountIt count = Counter();

            int result = count(3);
            Console.WriteLine("Сума 3 равна " + result);
            Console.WriteLine();
            
            result = count(5);
            Console.WriteLine("Сума 5 равна " + result);
        }
    }
}
