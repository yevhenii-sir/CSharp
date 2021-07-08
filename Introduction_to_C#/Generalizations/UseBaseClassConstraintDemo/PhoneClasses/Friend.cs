namespace LearnCSharp
{
    public class Friend : PhoneNumber
    {
        public bool IsWorkNumber { get; private set; }
        
        public Friend(string n, string num, bool wk) : base(n, num)
        {
            IsWorkNumber = wk;
        }
    }
}
