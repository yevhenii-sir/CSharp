using System;
using System.Diagnostics;

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

            Stopwatch spentTime = new Stopwatch();
            do
            {
                numbOfEnteredChars = arg.InputConsoleTextLength;
                ConsoleKeyInfo key = Console.ReadKey(true);
                spentTime.Start();
                arg.Set(key, text, numbOfEnteredChars);
                keyboardEvent.PressButton(arg);
                
            } while (numbOfEnteredChars < fullLength - 1);
            
            spentTime.Stop();
            Console.WriteLine($"\n\nПотрачено времени: {spentTime.Elapsed.TotalSeconds:#.##} секунд." +
                              $"\nСкорость: {(fullLength * 60) / spentTime.Elapsed.TotalSeconds:#.##} знаков за минуту.");
            Console.WriteLine(arg.Mistakes + " - ошибок.");
        }
    }
}
