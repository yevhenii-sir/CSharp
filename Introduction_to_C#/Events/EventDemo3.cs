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
        private int id;

        public X(int x)
        {
            id = x;
        }
        public void XHandler()
        {
            Console.WriteLine("Событие получено объектом " + id);
        }
    }
    
    static class EventDemo3
    {
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();

            X o1 = new X(1);
            X o2 = new X(2);
            X o3 = new X(3);

            evt.SomeEvent += o1.XHandler;
            evt.SomeEvent += o2.XHandler;
            evt.SomeEvent += o3.XHandler;
            
            evt.OnSomeEvent();
        }
    }
}

/*

Событие получено объектом 1
Событие получено объектом 2
Событие получено объектом 3

 */

