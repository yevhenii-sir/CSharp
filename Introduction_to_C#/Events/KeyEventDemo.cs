using System;

namespace LearnCSharp
{
    class KeyEventArgs : EventArgs
    {
        public char ch;
    }

    class KeyEvent
    {
        public event EventHandler<KeyEventArgs> KeyPress;

        public void OnKeyPress(char key)
        {
            KeyEventArgs k = new KeyEventArgs();

            if (KeyPress != null)
            {
                k.ch = key;
                KeyPress(this, k);
            }
        }
    }
    
    static class KeyEventDemo
    {
        static void Main(string[] args)
        {
            KeyEvent kevt = new KeyEvent();
            ConsoleKeyInfo key;
            int count = 0;

            kevt.KeyPress += (sender, e) =>
                Console.WriteLine("Получено сообщение о нажатии клавишы: " + e.ch);

            kevt.KeyPress += (sender, e) => count++;
            
            Console.WriteLine("Введите несколько символов. " +
                              "По завершении введите точку.");

            do
            {
                key = Console.ReadKey(true);
                kevt.OnKeyPress(key.KeyChar);
            } while (key.KeyChar != '.');
            
            Console.WriteLine("Было нажато " + count + " клавиш.");
        }
    }
}

/*

Получено сообщение о нажатии клавишы: t
Получено сообщение о нажатии клавишы: e
Получено сообщение о нажатии клавишы: s
Получено сообщение о нажатии клавишы: t
Получено сообщение о нажатии клавишы: .
Было нажато 5 клавиш.

 */

