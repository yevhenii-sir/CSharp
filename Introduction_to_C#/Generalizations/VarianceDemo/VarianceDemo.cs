using System;

namespace LearnCSharp
{
    public static class VarianceDemo
    {
        public static void Main()
        {
            IMyCoVarGenIF<Alpha> alphaRef = new MyClass<Alpha>(new Alpha("Aplha #1"));

            Console.WriteLine("Имя объекта, на который ссылается переменная " +
                              "AlphaRef: " + alphaRef.GetObject().GetName());

            alphaRef = new MyClass<Beta>(new Beta("Beta #1"));
            
            Console.WriteLine("Имя объекта, на который теперь ссылается переменная " +
                              "AlphaRef: " + alphaRef.GetObject().GetName());
            
        }
    }
}
