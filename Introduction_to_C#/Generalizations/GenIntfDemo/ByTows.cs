namespace LearnCSharp
{
    public class ByTows<T> : ISeries<T>
    {
        private T start;
        private T val;

        public delegate T IncByTwo(T v);
        private IncByTwo incr;

        public ByTows(IncByTwo incrMeth)
        {
            start = default(T);
            val = default(T);
            incr = incrMeth;
        }

        public T GetNext()
        {
            val = incr(val);
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(T v)
        {
            start = v;
            val = start;
        }
    }
}
