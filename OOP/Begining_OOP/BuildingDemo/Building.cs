using System;

namespace Basic_Learn_Csharp
{
    class Building
    {
        public int Floors;
        public int Area;
        public int Occupants;

        public Building(int f, int a, int o)
        {
            Floors = f;
            Area = a;
            Occupants = o;
        }

        public int AreaPerPerson()
        {
            return Area / Occupants;
        }

        public int MaxOccupant(int minArea)
        {
            return Area / minArea;
        }
    }
}
