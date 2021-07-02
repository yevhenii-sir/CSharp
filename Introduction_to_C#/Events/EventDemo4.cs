using System;

namespace LearnCSharp
{
    delegate void MyEventHandler();

    class MyEvent
    {
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent();
        }
    }

    class X
    {
        public static void XHandler()
        {
            Console.WriteLine("Событие получено классом.");
        }
    }
    
    static class EventDemo4
    {
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();

            evt.SomeEvent += X.XHandler;
            
            evt.OnSomeEvent();
        }
    }
}

