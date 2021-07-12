namespace LearnCSharp
{
    public class Stack<T>
    {
        private T[] stk;
        public int Tos { get; private set; }

        public Stack(int size)
        {
            stk = new T[size];
            Tos = 0;
        }

        public void Push(T ob)
        {
            if (IsFull()) throw new StackException("Стек заполнен!");

            stk[Tos] = ob;
            Tos++;
        }

        public T Pop()
        {
            if (IsEmpty()) throw new StackException("Стек пуст!");

            Tos--;
            return stk[Tos];
        }

        public bool IsFull()
        {
            return (Tos == stk.Length);
        }

        public bool IsEmpty()
        {
            return Tos == 0;
        }

        public int Capacity()
        {
            return stk.Length;
        }
    }
}
