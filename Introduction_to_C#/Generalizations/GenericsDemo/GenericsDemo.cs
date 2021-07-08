using System;

namespace LearnCSharp
{
    static class GenericsDemo
    {
        static void Main()
        {
            Gen<int> iOb;
            iOb = new Gen<int>(102);
            iOb.ShowType();

            int v = iOb.GetOb();
            Console.WriteLine("Значение: " + v);
            Console.WriteLine();

            Gen<string> strOb = new Gen<string>("Обобщения повышают эфективность.");
            strOb.ShowType();

            string str = strOb.GetOb();
            Console.WriteLine("Значение: " + str);
        }
    }
}
