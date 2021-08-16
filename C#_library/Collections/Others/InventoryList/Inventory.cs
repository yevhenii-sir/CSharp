using System;

namespace LearnCSharpCollections
{
    public class Inventory
    {
        public string name;
        private double cost;
        private int onhand;

        public Inventory(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }

        public override string ToString()
        {
            return String.Format($"{name, -10}Стоимость: {cost, 6:C} Наличие: {onhand}");
        }
    }
}
