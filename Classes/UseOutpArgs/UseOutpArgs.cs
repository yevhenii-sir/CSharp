using System;

namespace BasicLearnCSharp
{
    static class UseOptArgs
    {
        static void Display(string str, int start = 0, int stop = -1) 
        { 
            if (stop < 0) stop = str.Length;
            
            if (stop > str.Length | start > stop | start < 0) return;

            for (int i = start; i < stop; i++)
            {
                    Console.Write(str[i]);
            }
                
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
             Display("Это простой тест");
             Display("Это простой тест", 12);
             Display("Это простой тест", 4, 14);
        }
    }
}
