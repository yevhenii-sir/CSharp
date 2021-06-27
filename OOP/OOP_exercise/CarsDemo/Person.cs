namespace Exercise
{
    public class Person
    {
        public int Age { get; set; }
        
        public string FullName { get; set; }

        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        public override string ToString()
        {
            return "\tФИО - " + FullName +
                   "\n\tВозраст - " + Age;
        }
    }
}
