using System;

namespace LearnCSharp
{
    public static class CompareDemo
    {
        public static bool IsIn<T>(T what, T[] obs) where T : IEquatable<T>
        {
            foreach (T v in obs)
            {
                if (v.Equals(what)) return true;
            }

            return false;
        }

        public static bool InRange<T>(T what, T[] obs) where T : IComparable<T>
        {
            if ((what.CompareTo(obs[0]) < 0) || what.CompareTo(obs[^1]) > 0) return false; //знак ^ - отсчет от конца масива
            return true;
        }
        
        public static void Main()
        {
            int[] nums = {1, 2, 3, 4, 5};
            
            if (IsIn(2, nums)) 
                Console.WriteLine("Найдено значение 2.");
            
            if (IsIn(99, nums)) 
                Console.WriteLine("Не подлежит выводу.");

            MyClass[] mcs =
            {
                new MyClass(1),
                new MyClass(2),
                new MyClass(3),
                new MyClass(4)
            };
            
            if (IsIn(new MyClass(3), mcs)) 
                Console.WriteLine("Найден объект MyClass(3)");
            
            if (IsIn(new MyClass(99), mcs))
                Console.WriteLine("Не подлежит выводу.");
            
            if (InRange(2, nums)) 
                Console.WriteLine("Значение 2 находиться в границах массива nums.");
            if (InRange(1, nums)) 
                Console.WriteLine("Значение 1 находиться в границах массива nums.");
            if (InRange(5, nums)) 
                Console.WriteLine("Значение 5 находиться в границах массива nums.");
            if (!InRange(0, nums)) 
                Console.WriteLine("Значение 0 HE находиться в границах массива nums.");
            if (!InRange(6, nums)) 
                Console.WriteLine("Значение 6 HE находиться в границах массива nums.");
            
            if (InRange(new MyClass(2), mcs)) 
                Console.WriteLine("Объект MyClass(2) находиться в границах массива nums");
            if (InRange(new MyClass(1), mcs)) 
                Console.WriteLine("Объект MyClass(1) находиться в границах массива nums");
            if (InRange(new MyClass(4), mcs)) 
                Console.WriteLine("Объект MyClass(4) находиться в границах массива nums");
            if (!InRange(new MyClass(0), mcs)) 
                Console.WriteLine("Объект MyClass(0) HE находиться в границах массива nums");
            if (!InRange(new MyClass(5), mcs)) 
                Console.WriteLine("Объект MyClass(5) HE находиться в границах массива nums");
        }
    }
}
