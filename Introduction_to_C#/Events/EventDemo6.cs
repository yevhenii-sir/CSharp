using System;

namespace LearnCSharp
{
    class MyEventArgs : EventArgs
    {
        public int EventNum;
    }
    
    delegate void MyEventHandler(object source, MyEventArgs arg);

    class MyEvent
    {
        private static int _count = 0;

        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            MyEventArgs arg = new MyEventArgs();

            if (SomeEvent != null)
            {
                arg.EventNum = _count++;
                SomeEvent(this, arg);
            }
        }
    }

    class X
    {
        public void Handler(object source, MyEventArgs args)
        {
            Console.WriteLine("Событие " + args.EventNum + 
                              " получено объектом класса X.");
            
            Console.WriteLine("Источник: " + source);
            Console.WriteLine();
        }
    }
    
    class Y
    {
        public void Handler(object source, MyEventArgs args)
        {
            Console.WriteLine("Событие " + args.EventNum + 
                              " получено объектом класса Y.");
                
            Console.WriteLine("Источник: " + source);
            Console.WriteLine();
        }
    }

    static class EventDemo6
    {
        static void Main(string[] args)
        {
            X ob1 = new X();
            Y ob2 = new Y();
            
            MyEvent evt = new MyEvent();

            evt.SomeEvent += ob1.Handler;
            evt.SomeEvent += ob2.Handler;
            
            evt.OnSomeEvent();
            evt.OnSomeEvent();

            evt.SomeEvent -= ob1.Handler;
            evt.OnSomeEvent();
        }
    }
}

