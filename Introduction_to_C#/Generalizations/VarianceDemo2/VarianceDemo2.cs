using System;

namespace LearnCSharp
{
    public static class VarianceDemo2
    {
        public static void Main()
        {
            IMyContraVarGenIF<Alpha> AlphaRef = new MeClass<Alpha>();

            IMyContraVarGenIF<Beta> BetaRef = new MeClass<Beta>();

            IMyContraVarGenIF<Beta> BetaRef2 = new MeClass<Alpha>();
            
            BetaRef.Show(new Beta());

            BetaRef = AlphaRef;
            
            BetaRef.Show(new Beta());
            
        }
    }
}
