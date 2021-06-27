using Exercise.Details;
using Exercise.Professions;

namespace Exercise.Vehicles
{
    public class Lorry : Car
    {
        public int Carrying { get; set; }

        public Lorry(int carrying, string model, string carClass,
            double weight, Driver driver, Engine engine) : 
            base(model, carClass, weight, driver, engine)
        {
            Carrying = carrying;
        }

        public override string ToString()
        {
            return base.ToString() +
                   "\nГрузоподъемность - " + Carrying + " т.";
        }
    }
}
