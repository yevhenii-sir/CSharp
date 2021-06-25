namespace LearnCSharpInterface
{
    public class ByTows : ISeries
    {
        private int val;
        
        public ByTows()
        {
            val = 0;
        }

        public int Next
        {
            get
            {
                val += 2;
                return val;
            }
            set
            {
                val = value;
            }
        }
    }
}
