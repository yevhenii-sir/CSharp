using System;

namespace LearnCSharp
{
    public static class AmbiguityDemo
    {
        public static void Main()
        {
            Gen<int, double> ok = new Gen<int, double>();
            Gen<int, int> nonOk = new Gen<int, int>();
            
            ok.Set(10);
            nonOk.Set(10); //неоднозначно
        }
    }
}
