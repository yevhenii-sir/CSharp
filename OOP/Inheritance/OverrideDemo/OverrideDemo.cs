using System;

namespace CSharpLearn
{
    static class OverrideDemo
    {
        static void Main(string[] args)
        {
            Base baseOb = new Base();
            Derived1 dOb1 = new Derived1();
            Derived2 dOb2 = new Derived2();

            Base baseRef;

            baseRef = baseOb;
            baseRef.Who();

            baseRef = dOb1;
            baseRef.Who();
            
            baseRef = dOb2;
            baseRef.Who();
        }
    }
}
