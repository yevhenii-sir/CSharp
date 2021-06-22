namespace CSharpLearn
{
    static class OverrideDemo
    {
        static void Main(string[] args)
        {
            Derived3 dOb = new Derived3();
            Base baseRef;

            baseRef = dOb;
            baseRef.Who();
        }
    }
}
