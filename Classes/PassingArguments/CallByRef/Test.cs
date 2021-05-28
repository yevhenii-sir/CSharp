namespace BasicLearnCSharp
{
    public class Test
    {
        public int a, b;
        public Test(int i, int j)
        {
            a = i;
            b = j;
        }

        public void Change(Test ob)
        {
            ob.a = ob.a + ob.b;
            ob.b = -ob.b;
        }
        
    }
}
