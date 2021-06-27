using Exercise.Details;
using Exercise.Professions;

namespace Exercise.Vehicles
{
    public class SportCar : Car
    {
        public double Speed { get; set; }

        public SportCar(double speed, string model, string carClass,
            double weight, Driver driver, Engine engine) :
            base(model, carClass, weight, driver, engine)
        {
            Speed = speed;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nМаксимальная скорость - {Speed:#.##}";
        }
    }
}
