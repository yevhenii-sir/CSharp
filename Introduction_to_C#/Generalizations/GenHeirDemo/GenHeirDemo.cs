using System;

namespace LearnCSharp
{
    public static class GenHeirDemo
    {
        public static void Main()
        {
            Gen2<string> g2 = new Gen2<string>("Привет");
            Console.WriteLine(g2.GetOb());
        }
    }
}
