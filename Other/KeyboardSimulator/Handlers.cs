using System;

namespace KeyboardSimulator
{
    public static class Handlers
    {
        public static void ComprasionHandler (object source, MyEventArgs arg)
        {
            if (arg.Text[arg.InputConsoleTextLength] == ((arg.Ch.Key == ConsoleKey.Enter) ? '\n' : '\0'))
            {
                Console.WriteLine();
                ++arg.InputConsoleTextLength;
            }
            
            if ((arg.Ch.KeyChar == arg.Text[arg.InputConsoleTextLength])) 
            {
                Console.Write(arg.Ch.KeyChar);
                ++arg.InputConsoleTextLength;
            }
        }
    }
}
