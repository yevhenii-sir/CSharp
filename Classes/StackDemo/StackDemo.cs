using System;

namespace BasicLearnCSharp
{
    static class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);
            char ch;
            int i;
            
            Console.WriteLine("Поместить символы A - J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
            {
                stk1.Push((char) ('A' + i));
            }
            if (stk1.IsFull()) Console.WriteLine("Стек заполнен.");
            
            Console.Write("Содержимое stk1:");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }
            if (stk1.IsEmpty()) Console.WriteLine("\nСтек пуст.\n");
            
            Console.WriteLine("Вновь поместить символы A - J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
            {
                stk1.Push((char) ('A' + i));
            }
            
            Console.WriteLine("А теперь извлень символы из стека stk1" +
                              "и поместить их в стек stk2");

            while (!stk1.IsEmpty())
            {
                stk2.Push(stk1.Pop());
            }
            
            Console.Write("Содержимое стека stk2: ");
            while (!stk2.IsEmpty())
            {
                Console.Write(stk2.Pop());
            }
            
            Console.WriteLine("\n");
            
            Console.WriteLine("Поместить 5 символов в стек stk3");
            for (i = 0; i < 5; i++)
            {
                stk3.Push((char)('A' + i));
            }
            
            Console.WriteLine("Емкость стека stk3: " + stk3.Capacity());
            Console.WriteLine("Количество объектов в стеке stk3: " + stk3.GetNum());
        }
    }
}
