namespace LearnCSharp
{
    public struct XY<T>
    {
        private T x, y;

        public XY(T a, T b)
        {
            x = a;
            y = b;
        }

        public T X
        {
            get => x; // get { return x; }
            set => x = value; // set { x = value; }
        }
        
        public T Y
        {
            get => y; // get { return y; }
            set => y = value; // set { y = value; }
        }
    }
}
