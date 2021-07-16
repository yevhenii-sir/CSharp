using System;

namespace LearnCSharpOther
{
    unsafe struct FixedBankRecord
    {
        public fixed byte Name[80];
        public double Balance;
        public long ID;
    }
    
    static class FixedSizeBuffer
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine("Размер структуры FixedBankRecord: " + 
                              sizeof(FixedBankRecord));
        }
    }
}
