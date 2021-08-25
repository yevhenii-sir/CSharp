namespace LearnCSharpOther
{
    static class DefaultInterfaces
    {
        static void Main(string[] args)
        {
            IMovable tom = new Person();
            Car tesla = new Car();
            tom.Move();
            tesla.Move();
        }
    }
}

/*

Walking
Driving

 */

