using System;

namespace LearnCSharpCollections
{
    public class Inventory: IComparable
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

        public int CompareTo(object obj)
        {
            Inventory b = (Inventory)obj;
            return name.CompareTo(b.name);
        }

        public override string ToString()
        {
            return String.Format($"{name, -10}Стоимость: {cost, 6:C} Наличие: {onhand}");
        }
    }
}
