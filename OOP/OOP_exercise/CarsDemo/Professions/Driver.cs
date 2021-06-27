namespace Exercise.Professions
{
    public class Driver : Person
    {
        public int DrivingExp { get; set; }

        public Driver(string fullName, int age, int drivingExp) : base(fullName, age)
        {
            DrivingExp = drivingExp;
        }

        public override string ToString()
        {
            return "\tСтаж водителя - " + DrivingExp + " лет" +
                   "\n" + base.ToString();
        }
    }
}
