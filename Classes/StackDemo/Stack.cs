using System;

namespace BasicLearnCSharp
{
    public class Stack
    {
        private char[] stk;
        private int tos;

        public Stack(int size)
        {
            stk = new char[size];
            tos = 0;
        }

        public Stack(Stack ob)
        {
            stk = new char[ob.stk.Length];

            for (int i = 0; i < ob.tos; i++)
            {
                stk[i] = ob.stk[i];
            }

            tos = ob.tos;
        }

        public void Push(char ch)
        {
            if (tos == stk.Length)
            {
                Console.WriteLine(" - Стек заполнен!");
                return;
            }

            stk[tos] = ch;
            tos++;
        }

        public char Pop()
        {
            if (tos == 0)
            {
                Console.WriteLine(" - Стек пуст!");
                return (char) 0;
            }

            tos--;
            return stk[tos];
        }

        public bool IsFull()
        {
            return (tos == stk.Length);
        }

        public bool IsEmpty()
        {
            return tos == 0;
        }

        public int Capacity()
        {
            return stk.Length;
        }

        public int GetNum()
        {
            return tos;
        }
    }
}
