using System;

namespace LearnCSharpException
{
    static class UseExcept
    {
        static void Main(string[] args)
        {
            try
            {
                ExcTest.GetException();
            }
            catch (IndexOutOfRangeException exc)
            {
                Console.WriteLine("Стандартное сообщение таково:\n" + exc + "\n");
                Console.WriteLine("Свойство StackTrace: " + exc.StackTrace);
                Console.WriteLine("Свойство Message: " + exc.Message);
                Console.WriteLine("Свойство TargetSite: " + exc.TargetSite);
            }
            Console.WriteLine("После блока перехвата исключения.");
        }
    }
}

/* 

nums[0]: 0
nums[1]: 1
nums[2]: 2
nums[3]: 3
Стандартное сообщение таково:
System.IndexOutOfRangeException: Index was outside the bounds of the array.
   at LearnCSharpException.ExcTest.GetException() in /home/ainerond/RiderProjects/LearnCSharpException/LearnCSharpException/ExcTest.cs:line 13
   at LearnCSharpException.UseExcept.Main(String[] args) in /home/ainerond/RiderProjects/LearnCSharpException/LearnCSharpException/Program.cs:line 11

Свойство StackTrace:    at LearnCSharpException.ExcTest.GetException() in /home/ainerond/RiderProjects/LearnCSharpException/LearnCSharpException/ExcTest.cs:line 13
   at LearnCSharpException.UseExcept.Main(String[] args) in /home/ainerond/RiderProjects/LearnCSharpException/LearnCSharpException/Program.cs:line 11
Свойство Message: Index was outside the bounds of the array.
Свойство TargetSite: Void GetException()
После блока перехвата исключения.

*/
