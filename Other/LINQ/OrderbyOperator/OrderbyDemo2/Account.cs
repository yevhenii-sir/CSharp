namespace LearnCSharpLINQ
{
    public class Account
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Balance { get; private set; }
        public string AccountNumber { get; private set; }

        public Account(string fn, string ln, string accnum, double b)
        {
            FirstName = fn;
            LastName = ln;
            AccountNumber = accnum;
            Balance = b;
        }
    }
}
