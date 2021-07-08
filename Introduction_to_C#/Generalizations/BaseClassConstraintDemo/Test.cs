namespace LearnCSharp
{
    public class Test<T> where T : A
    {
        private T obj;

        public Test(T ob)
        {
            obj = ob;
        }

        public void SayHello()
        {
            obj.Hello();
        }
    }
}
