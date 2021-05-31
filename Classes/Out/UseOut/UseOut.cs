using System;

namespace BasicLearnCSharp
{
    static class UseOut
    {
        static void Main(string[] args)
        {
            Decompose ob = new Decompose();
            int i;
            double f;

            i = ob.GetParts(10.125, out f);
            
            Console.WriteLine("Целая часть числа равна: " + i +
                              "\nДробная часть числа равна: " + f);
        }
    }
}
