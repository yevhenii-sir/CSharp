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

        public int this[int index]
        {
            get
            {
                val = 0;
                for (int i = 0; i < index; i++)
                    val += 2;

                return val;
            }
        }
    }
}
