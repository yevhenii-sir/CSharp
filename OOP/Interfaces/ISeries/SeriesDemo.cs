using System;

namespace LearnCSharpInterface
{
    static class SeriesDemo
    {
        static void Main(string[] args)
        {
            ByTows twoOb = new ByTows();
            Primes primeOb = new Primes();
            ISeries ob;

            for (int i = 0; i < 5; i++)
            {
                ob = twoOb;
                Console.WriteLine("Следующие четное число равно " + ob.GetNext());

                ob = primeOb;
                Console.WriteLine("Следующие простое число равно " + ob.GetNext());
            }
        }
    }
}
