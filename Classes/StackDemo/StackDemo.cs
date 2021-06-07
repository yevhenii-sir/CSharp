using System;

namespace BasicLearnCSharp
{
    static class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stk1 = new Stack(10);
            char ch;
            int i;
            
            Console.WriteLine("Поместить символы A - J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
            {
                stk1.Push((char) ('A' + i));
            }

            Stack stk2 = new Stack(stk1);
            
            Console.Write("Содержимое стека stk1: ");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }
            
            Console.WriteLine();
            
            Console.Write("Содержимое стека stk2: ");
            while (!stk2.IsEmpty())
            {
                Console.Write(stk2.Pop());
            }
        }
    }
}
