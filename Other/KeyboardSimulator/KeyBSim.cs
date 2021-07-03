using System;
using System.Diagnostics;
using System.IO;

namespace KeyboardSimulator
{
    static class KeyBSim
    {
        static void Main(string[] args)
        {
            WordAndFileProcessing.TextDataOutput(out int fullLength, out string text);
            
            KeyboardEvent keyboardEvent = new KeyboardEvent();
            keyboardEvent.OnPressButton += Handlers.ComprasionHandler;

            MyEventArgs arg = new MyEventArgs {InputConsoleTextLength = 0};
            
            Console.WriteLine("Текст из файла: ");
            Console.WriteLine(text + "\n");
            
            Console.WriteLine("Введи текст: ");
            int numbOfEnteredChars;
            do
            {
                numbOfEnteredChars = arg.InputConsoleTextLength;
                ConsoleKeyInfo key = Console.ReadKey(true);
                arg.Set(key, text, numbOfEnteredChars);
                keyboardEvent.PressButton(arg);
            } while (numbOfEnteredChars < fullLength - 1);

        }
    }
}
