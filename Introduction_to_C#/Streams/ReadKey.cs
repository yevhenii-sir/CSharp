using System;

namespace LearnCSharpStreams
{
    public static class ReadKeys
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keypress;
            
            Console.WriteLine("Введите несколько символов, " + 
                              "а по окончании - <Q>.");

            do
            {
                keypress = Console.ReadKey(true);
                Console.WriteLine("Вы нажали клавишу: " + keypress.KeyChar);

                if ((ConsoleModifiers.Alt & keypress.Modifiers) != 0)
                {
                    Console.WriteLine("Нажата клавиша <Alt>.");
                }

                if ((ConsoleModifiers.Control & keypress.Modifiers) != 0)
                {
                    Console.WriteLine("Нажата клавиша <Control>.");
                }
                
                if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0)
                {
                    Console.WriteLine("Нажата клавиша <Shift>.");
                }
                Console.WriteLine("----------------------");
            } while (keypress.KeyChar != 'Q');
        }
    }
}
