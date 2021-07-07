using System;

namespace LearnCSharp
{
    class ObsoleteDemo
    {
        [Obsolete("Лучше использовать метод MyMeth2.")] //Obsolete("Лучше использовать метод MyMeth2.", true) - ошибка компиляции
        public static int MyMeth(int a, int b)
        {
            return a / b;
        }

        public static int MyMeth2(int a, int b)
        {
            return b == 0 ? 0 : a / b;
        }
        
        static void Main()
        {
            Console.WriteLine("4 / 3 равно " + MyMeth(4, 3)); //устаревший метод
            
            Console.WriteLine("4 / 3 равно " + MyMeth2(4, 3));
        }
    }
}
