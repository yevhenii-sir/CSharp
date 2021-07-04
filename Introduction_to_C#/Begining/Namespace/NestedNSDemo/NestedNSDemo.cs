namespace LearnCSharp
{
    static class NestedNSDemo
    {
        static void Main(string[] args)
        {
            NS1.ClassA a = new NS1.ClassA();

            NS1.NS2.ClassB b = new NS1.NS2.ClassB();
        }
    }
}
