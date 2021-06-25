namespace LearnCSharpInterface
{
    public class ByTows : ISeries
    {
        private int start;
        private int val;

        public ByTows()
        {
            start = 0;
            val = 0;
        }

        public int GetNext()
        {
            val += 2;
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }
}
