namespace LearnCSharp
{
    public class Test<T>
    {
        public T obj { get; private set; }

        public Test()
        {
            obj = default(T);
        }
        
        // ...
    }
}
