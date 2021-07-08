using System;

namespace LearnCSharp
{
    static class SimpGen
    {
        static void Main()
        {
            TwoGen<int, string> tgObj = new TwoGen<int, string>(119, "Альфа Бета Гамма");
            tgObj.ShowTypes();

            int v = tgObj.GetOb1();
            Console.WriteLine("Значение: " + v);

            string str = tgObj.GetOb2();
            Console.WriteLine("Значение: " + str);
        }
    }
}
