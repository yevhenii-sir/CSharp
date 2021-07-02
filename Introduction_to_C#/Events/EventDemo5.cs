using System;

namespace LearnCSharp
{
    delegate void MyEventHandler();

    class MyEvent
    {
        private MyEventHandler[] evnt = new MyEventHandler[3];
        
        public event MyEventHandler SomeEvent
        {
            add
            {
                int i;

                for (i = 0; i < 3; i++)
                {
                    if (evnt[i] == null)
                    {
                        evnt[i] = value;
                        break;
                    }
                }
                if (i == 3) Console.WriteLine("Список событий заполнен.");
            }
            remove
            {
                int i;

                for (i = 0; i < 3; i++)
                {
                    if (evnt[i] == value)
                    {
                        evnt[i] = null;
                        break;
                    }
                }
                if (i == 3) Console.WriteLine("Обработчик событий не найден.");
            }
        }

        public void OnSomeEvent()
        {
            for (int i = 0; i < 3; i++)
            {
                if (evnt[i] != null) evnt[i]();
            }
        }
    }

    class W
    {
        public void WHandler()
        {
            Console.WriteLine("Событие получено объектом W");
        }
    }
    
    class X
    {
        public void XHandler()
        {
            Console.WriteLine("Событие получено объектом X");
        }
    }
    
    class Y
    {
        public void YHandler()
        {
            Console.WriteLine("Событие получено объектом Y");
        }
    }
    
    class Z
    {
        public void ZHandler()
        {
            Console.WriteLine("Событие получено объектом Z");
        }
    }
    
    
    
    static class EventDemo5
    {
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();

            W wOb = new W();
            X xOb = new X();
            Y yOb = new Y();
            Z zOb = new Z();
            
            Console.WriteLine("Добавление событий.");
            evt.SomeEvent += wOb.WHandler;
            evt.SomeEvent += xOb.XHandler;
            evt.SomeEvent += yOb.YHandler;

            evt.SomeEvent += zOb.ZHandler; //error
            Console.WriteLine();
            
            evt.OnSomeEvent();
            Console.WriteLine();
            
            Console.WriteLine("Удаление обработчика xOb.XHandler");
            evt.SomeEvent -= xOb.XHandler;
            evt.OnSomeEvent();
            
            Console.WriteLine();
            
            Console.WriteLine("Попытка еще раз удалить обработчик " +
                              "xOb.XHandler");
            evt.SomeEvent -= xOb.XHandler;
            evt.OnSomeEvent();
            
            Console.WriteLine();
            
            Console.WriteLine("Добавление обработчика zOb.ZHandler");
            evt.SomeEvent += zOb.ZHandler;
            evt.OnSomeEvent();
        }
    }
}

