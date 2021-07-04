using Ctr = Counter;
using CtrA = AnotherCounter;

public class CountDown
{
    private int val;

    public CountDown(int n)
    {
        val = n;
    }

    // ...
}

namespace LearnCSharp
{
    static class WhyAliasQualifier
    {
        static void Main(string[] args)
        {
            Ctr::CountDown cd1 = new Ctr::CountDown(10); 
            
            CtrA::CountDown cd2 = new CtrA::CountDown(10);

            global::CountDown cd3 = new global::CountDown(5);
        }
    }
}
