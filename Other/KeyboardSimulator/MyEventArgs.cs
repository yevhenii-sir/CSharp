using System;

namespace KeyboardSimulator
{
    public class MyEventArgs : EventArgs
    {
        public ConsoleKeyInfo Ch { get; set; }
        public string Text { get; set; }
        public int InputConsoleTextLength { get; set; }
        public int Mistakes { get; set; }

        public void Set(ConsoleKeyInfo ch, string text, int inputConsoleTextLength)
        {
            Ch = ch;
            Text = text;
            InputConsoleTextLength = inputConsoleTextLength;
        }
    }
}
