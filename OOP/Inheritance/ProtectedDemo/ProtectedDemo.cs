namespace ProtectedDemo
{
    static class ProtectedDemo
    {
        static void Main(string[] args)
        {
            D ob = new D();
            ob.Set(2, 3);
            
            ob.Show();
            ob.Setk();
            ob.Showk();
        }
    }
}
