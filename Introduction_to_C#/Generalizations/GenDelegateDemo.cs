using System;

namespace LearnCSharp
{
    delegate T SomeOp<T>(T v);
    
    public static class GenDelegateDemo
    {
        static int Sum(int v)
        {
            int result = 0;
            for (int i = v; i > 0; i--)
                result += i;
            
            return result;
        }

        static string Reflect(string str)
        {
            string result = "";

            foreach (var ch in str)
            {
                result = ch + result;
            }

            return result;
        }
        
        public static void Main()
        {
            SomeOp<int> intDel = Sum;
            Console.WriteLine(intDel(3));

            SomeOp<string> strDel = Reflect;
            Console.WriteLine(strDel("Привет!"));
        }
    }
}
