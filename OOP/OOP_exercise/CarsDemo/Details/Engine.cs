namespace Exercise.Details
{
    public class Engine
    {
        public int Power { get; set; }
        
        public string Company { get; set; }

        public Engine(int power, string company)
        {
            Power = power;
            Company = company;
        }

        public override string ToString()
        {
            return "\tМощность двигателя - " + Power +
                   "\n\tИзготовитель - " + Company;
        }
    }
}
