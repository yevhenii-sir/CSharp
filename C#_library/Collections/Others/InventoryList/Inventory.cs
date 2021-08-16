using System;

namespace LearnCSharpCollections
{
    public class Inventory: IComparable<Inventory>
    {
        private string name;
        private double cost;
        private int onhand;

        public Inventory(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }

        public int CompareTo(Inventory other)
        {
            return name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return String.Format($"{name, -10}Стоимость: {cost, 6:C} Наличие: {onhand}");
        }
    }
}
