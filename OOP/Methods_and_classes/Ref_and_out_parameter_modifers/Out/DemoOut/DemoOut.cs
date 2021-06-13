using System;

namespace BasicLearnCSharp
{
    static class DemoOut
    {
        static void Main(string[] args)
        {
            Num ob = new Num();

            int lcf, gcf;
            
            ob.ShowHasComFactor(35, 51);
            
            if (ob.HasComFactor(231, 105, out lcf, out gcf))
            {
                Console.WriteLine("Наименьший общий множитель чисел 231 и 105 равен: " + lcf);
                Console.WriteLine("Наибольший общий множитель чисел 231 и 105 равен: " + gcf);
            }
            else
            {
                Console.WriteLine("Общий множитель у чисел 231 и 105 отсутствует.");
            }
            
        }
    }
}
