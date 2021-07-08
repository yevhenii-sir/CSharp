namespace LearnCSharp
{
    public class PhoneNumber
    {
        public string Number { get; set; }
        public string Name { get; set; }

        public PhoneNumber(string n, string num)
        {
            Name = n;
            Number = num;
        }
    }
}
