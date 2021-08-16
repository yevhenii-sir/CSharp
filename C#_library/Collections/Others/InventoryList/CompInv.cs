using System;
using System.Collections;

namespace LearnCSharpCollections
{
    public class CompInv : IComparer
    {
        public int Compare(object x, object y)
        {
            Inventory a = (Inventory)x;
            Inventory b = (Inventory)y;

            return string.Compare(a.name, b.name, StringComparison.Ordinal);
        }
    }
}
