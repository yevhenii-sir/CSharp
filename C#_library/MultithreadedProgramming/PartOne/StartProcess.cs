using System;
using System.Diagnostics;

namespace LearnCSharpMultiThrProgramming
{
    static class StartProcess
    {
        static void Main(string[] args)
        {
            Process newProcess = Process.Start("firefox"); //or okular for test
            
            Console.WriteLine("Новый процес запущен.");

            newProcess?.WaitForExit();
            
            Console.WriteLine("Новый процес завершен.");
        }
    }
}


