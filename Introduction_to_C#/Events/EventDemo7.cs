using System;

namespace LearnCSharp
{
    class MyEvent
    {
        public event EventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
            {
                SomeEvent(this, EventArgs.Empty);
            }
        }
    }
    
    static class EventDemo7
    {
        private static void Handler(object source, EventArgs args)
        {
            Console.WriteLine("Произошло событие");
            Console.WriteLine("Источник: " + source);
        }
        
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();

            evt.SomeEvent += Handler;
            
            evt.OnSomeEvent();
        }
    }
}

