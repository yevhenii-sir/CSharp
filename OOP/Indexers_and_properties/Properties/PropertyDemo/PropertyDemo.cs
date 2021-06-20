using System;

namespace BasicLearnCSharp
{
    static class PropertyDemo
    {
        static void Main(string[] args)
        {
            SimpProp ob = new SimpProp();
            
            Console.WriteLine("Первоначальное значение ob.MyProp: " + ob.MyProp);

            ob.MyProp = 100;
            Console.WriteLine("Попытка прсиоить значение " +
                              "-10 свойству ob.MyProp");

            ob.MyProp = -10;
            Console.WriteLine("Текущее значение ob.MyProp: " + ob.MyProp);
        }
    }
}
