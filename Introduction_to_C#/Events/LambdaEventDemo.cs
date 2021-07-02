using System;

namespace LearnCSharp
{
    delegate void MyEventHandler(int n);

    class MyEvent
    {
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent(int n)
        {
            if (SomeEvent != null)
            {
                SomeEvent(n);
            }
        }
    }

    static class LambdaEventDemo
    {
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();

            evt.SomeEvent += n => 
                Console.WriteLine("Событие получено. Значение равно " + n); //не получится удалить обработчик события с очереди
            
            /*MyEventHandler ShowN = n => 
                Console.WriteLine("Событие получено. Значение равно " + n);
            evt.SomeEvent += ShowN;
            evt.SomeEvent -= ShowN;*/
            
            evt.OnSomeEvent(1);
            evt.OnSomeEvent(2);
        }
    }
}

