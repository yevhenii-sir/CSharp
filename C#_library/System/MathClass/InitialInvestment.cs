using System;

namespace LearnCSharpOther
{
    static class InitialInvestment
    {
        static void Main(string[] args)
        {
            decimal initInvest;
            decimal futVal;

            double numYears;
            double intRate;

            string str;
            
            Console.Write("Введите будущую стоимость: ");
            str = Console.ReadLine();
            try
            {
                futVal = Decimal.Parse(str);
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            
            Console.Write("Введите норму прыбили (например, 0.085): ");
            str = Console.ReadLine();
            try
            {
                intRate = Double.Parse(str);
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            
            Console.Write("Введите количество лет: ");
            str = Console.ReadLine();
            try
            {
                numYears = Double.Parse(str);
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }

            initInvest = futVal / (decimal) Math.Pow(intRate + 1.0, numYears);
            
            Console.WriteLine("Необходимые первоначальные капиталовложения: {0:C}", initInvest);
        }
    }
}

/*

Введите будущую стоимость: 10000
Введите норму прыбили (например, 0.085): 0,07
Введите количество лет: 10
Необходимые первоначальные капиталовложения: 5 083,49 ₴

*/
