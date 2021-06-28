using System;

namespace LearnCSharpException
{
    public class UseFinally
    {
        public static void GetException(int what)
        {
            int t;
            int[] nums = new int[2];
            
            Console.WriteLine("Получить " + what);
            try
            {
                switch (what)
                {
                    case 0:
                        t = 10 / what;
                        break;
                    case 1:
                        nums[4] = 4;
                        break;
                    case 2:
                        return;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на нуль нельзя!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Совпадающий елемент найден.");
            }
            finally
            {
                Console.WriteLine("После выхода из блока try.");
            }
        }
    }
}
