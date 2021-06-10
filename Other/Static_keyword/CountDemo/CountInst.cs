namespace BasicLearnCSharp
{
    public class CountInst
    {
        private static int count = 0;

        public CountInst()
        {
            count++;
        }

        ~CountInst()
        {
            count--;
        }

        public static int GetCount()
        {
            return count;
        }
    }
}
