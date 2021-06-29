using System;

namespace LearnCSharpStreams
{
    public static class KbIn
    {
        static void Main(string[] args)
        {
            Console.Write("Нажмите клавишу, а затем - <ENTER>: ");

            char ch = (char) Console.Read();
            
            Console.WriteLine("Вы нажали клавишу: " + ch);
        }
    }
}
