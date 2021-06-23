namespace CSharpLearn
{
    public class MyClass
    {
        private static int count = 0;
        private int id;

        public MyClass()
        {
            id = count;
            count++;
        }

        public override string ToString()
        {
            return "Объект #" + id + " типа MyClass";
        }
    }
}
