using System;

namespace BasicLearnCSharp
{
    static class UsePwrOfTwo
    {
        static void Main(string[] args)
        {
            PwrOfTwo pwr = new PwrOfTwo();
            
            Console.WriteLine("Первые 8 степеней числа 2: ");
            for(int i = 0; i < 8; i++) 
                Console.Write("{0, 5}",pwr[i]);
            
            Console.WriteLine();
            
            Console.Write("А вот некоторые ошибки: ");
            Console.Write(pwr[-1] + " " + pwr[17]);

            Console.WriteLine();
        }
    }
}
