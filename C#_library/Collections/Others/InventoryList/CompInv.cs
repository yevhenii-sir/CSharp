using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    public class CompInv<T> : IComparer<T> where T : Inventory
    {
        public int Compare(T x, T y)
        {
            return string.Compare(x.name, y.name, StringComparison.Ordinal);
        }
    }
}
