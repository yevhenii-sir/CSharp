using System;

namespace LearnCSharp
{
    delegate bool SomeOp<in T>(T obj);

    delegate T AnotherOup<out T, in V>(V obj);
    
    public static class GenDelegateVarianceDemo
    {
        static bool IsEven(Alpha obj)
        {
            if ((obj.Val % 2) == 0) return true;
            return false;
        }

        static Beta ChangeIt(Alpha obj)
        {
            return new Beta(obj.Val + 2);
        }
        
        public static void Main()
        {
            Alpha objA = new Alpha(4);
            Beta objB = new Beta(9);

            SomeOp<Alpha> checkIt = IsEven;
            SomeOp<Beta> checkIt2;

            checkIt2 = checkIt;
            
            Console.WriteLine(checkIt2(objB));

            AnotherOup<Beta, Alpha> modifyIt = ChangeIt;
            AnotherOup<Alpha, Alpha> modifyIt2;

            modifyIt2 = modifyIt;

            objA = modifyIt2(objA);
            Console.WriteLine(objA.Val);
        }
    }
}
