using System;
using System.IO;

namespace KeyboardSimulator
{
    public class KeyboardEvent
    {
        public event EventHandler<MyEventArgs> OnPressButton;

        public void PressButton(MyEventArgs args)
        {
            OnPressButton?.Invoke(this, args);
        }
        
    }
}
