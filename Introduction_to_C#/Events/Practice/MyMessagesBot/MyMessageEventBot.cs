using System;

namespace Exercise
{
    class MyMessageEventBot
    {
        public event EventHandler<MyMessArgs> OnMessage;

        public void OnMessageEvent (string mess)
        {
            MyMessArgs args = new MyMessArgs {Message = mess};
            
            OnMessage?.Invoke(this, args);
        }
    }
}
