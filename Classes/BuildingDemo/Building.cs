using System;

namespace Basic_Learn_Csharp
{
    class Building
    {
        public int Floors;
        public int Area;
        public int Occupants;

        public int AreaPerPerson()
        {
            return Area / Occupants;
        }
    }
}
