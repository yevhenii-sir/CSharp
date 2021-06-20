using System;

namespace BasicLearnCSharp
{
    static class PropAccessDemo
    {
        static void Main(string[] args)
        {
            PropAcces ob = new PropAcces();
            
            Console.WriteLine("Первоначальное значение ob.MyProp: " + ob.MyProp);
            //ob.MyProp = 100; // error, setter private
            
            ob.IncProp();
            Console.WriteLine("Значение ob.MyProp после инкрементирования: " + ob.MyProp);
        }
    }
}
