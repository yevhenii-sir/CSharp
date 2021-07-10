using System;

namespace LearnCSharp
{
    public static class GenHeirDemo2
    {
        public static void Main()
        {
            Gen<string> w = new Gen<string>("Привет", 47);
            
            Console.Write(w.GetOb() + " ");
            Console.WriteLine(w.GetNum());
        }
    }
}
