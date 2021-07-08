namespace LearnCSharp
{
    public class Friend : IPhoneNumber
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public bool IsWorkNumber { get; private set; }
        
        public Friend(string n, string num, bool wk)
        {
            Name = n;
            Number = num;
            
            IsWorkNumber = wk;
        }
    }
}
