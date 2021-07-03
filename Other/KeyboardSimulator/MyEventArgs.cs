using System;

namespace KeyboardSimulator
{
    public class MyEventArgs : EventArgs
    {
        public ConsoleKeyInfo Ch;
        public string Text;
        public int InputConsoleTextLength;

        public void Set(ConsoleKeyInfo ch, string text, int inputConsoleTextLength)
        {
            Ch = ch;
            Text = text;
            InputConsoleTextLength = inputConsoleTextLength;
        }
    }
}
