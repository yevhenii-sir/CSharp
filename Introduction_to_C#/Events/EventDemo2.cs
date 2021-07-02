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
        public void XHandler()
        {
            Console.WriteLine("Событие получено объектом класса X");
        }
    }

    class Y
    {
        public void YHandler()
        {
            Console.WriteLine("Событие получено объектом класса Y");
        }
    }

    static class EventDemo2
    {
        private static void Handler()
        {
            Console.WriteLine("Произошло событие");
        }

        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            X xOb = new X();
            Y yOb = new Y();

            evt.SomeEvent += Handler;
            evt.SomeEvent += xOb.XHandler;
            evt.SomeEvent += yOb.YHandler;
            MyEventHandler lambda = () => Console.WriteLine("Событие получено из лямбда-выражения");
            evt.SomeEvent += lambda;

            evt.OnSomeEvent();

            Console.WriteLine();
            evt.SomeEvent -= xOb.XHandler;
            evt.SomeEvent -= lambda;
            evt.OnSomeEvent();
        }
    }
}

/*
 * 
 * Произошло событие
 * Событие получено объектом класса X
 * Событие получено объектом класса Y
 * Событие получено из лямбда-выражения
 * 
 * Произошло событие
 * Событие получено объектом класса Y
 * Событие получено из лямбда-выражения
 *
 */

