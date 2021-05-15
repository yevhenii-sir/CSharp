using System;

namespace BasicLearnCSharp
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            char[] charray = {'Э', 'т', 'о', ' ', 'с', 'т', 'р', 'о', 'к', 'а'};

            string str1 = new string(charray);
            string str2 = "Еще одна строка.";
            
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}