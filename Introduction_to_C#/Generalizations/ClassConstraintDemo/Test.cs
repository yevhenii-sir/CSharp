namespace LearnCSharp
{
    public class Test<T> where T : class
    {
        private T obj;

        public Test()
        {
            obj = null;
        }
    }
}
