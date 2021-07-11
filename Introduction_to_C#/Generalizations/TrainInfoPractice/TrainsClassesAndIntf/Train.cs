using System;

namespace Exercise.TrainsClassesAndIntf
{
    public abstract class Train : IComparable<Train>, IEquatable<Train>
    {
        public string Name { get; set; }

        public double Power { get; set; }
        
        public int NumCarriage { get; set; }

        protected Train(string name, double power, int numCarriage)
        {
            Name = name;
            Power = power;
            NumCarriage = numCarriage;
        }

        public int CompareTo(Train other)
        {
            return (int) (this.Power - other.Power);
        }

        public bool Equals(Train other)
        {
            return Name == other?.Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Train)
            {
                return Equals((Train) obj);
            }

            return false;
        }

        protected Train(string name, double power) : this(name, power, -1) {}

        protected Train(string name) : this(name, -1.0, -1) {}

        public abstract void ShowTrainInfo();
    }
}
