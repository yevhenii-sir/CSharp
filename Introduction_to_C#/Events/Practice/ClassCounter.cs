using System;

namespace Exercise
{
    class Counter
    {
        public delegate void MethodCounter();

        public event MethodCounter OnCount;
            
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if ((i == 60) && (OnCount != null))
                {
                    OnCount();
                }
            }
        }
    }

    class Handler1
    {
        public void HandlerOne()
        {
            Console.WriteLine("Мы достигли до 60!");
        }
    }

    class Handler2
    {
        public void HandlerTwo()
        {
            Console.WriteLine("Точно 60!");
        }
    }
    
    static class Test
    {
        static void Main(string[] args)
        {
            Counter testEvent = new Counter();
            Handler1 ob1 = new Handler1();
            Handler2 ob2 = new Handler2();

            testEvent.OnCount += ob1.HandlerOne;
            testEvent.OnCount += ob2.HandlerTwo;
            
            testEvent.Count();
        }
    }
}


/*
 
Мы достигли до 60!
Точно 60!

*/

