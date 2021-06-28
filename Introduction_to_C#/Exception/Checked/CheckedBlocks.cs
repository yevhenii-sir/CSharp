using System;

namespace LearnCSharpException
{
    static class CheckedBlocks
    {
        static void Main(string[] args)
        {
            byte a, b;
            byte result;

            a = b = 127;
            
            try
            {
                unchecked
                {
                    a = b = 127;
                    result = unchecked((byte) (a * b));
                    
                    Console.WriteLine("Непроверенный на переполнение результат: " + 
                                      result);

                    a = 125;
                    b = 5;
                    result = (byte) (a * b);
                    
                    Console.WriteLine("Непроверенный на переполнение результат: " + 
                                      result);
                }
                checked
                {
                    a = 2;
                    b = 7;
                    
                    result = (byte) (a * b);
                    Console.WriteLine("Проверенный на переполнение результат: " + 
                                      result);

                    a = b = 127;
                    result = (byte) (a * b); //приводит к искю ситуации
                    Console.WriteLine("Проверенный на переполнение результат: " + 
                                      result);
                }
                
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}

/*

Непроверенный на переполнение результат: 1
Непроверенный на переполнение результат: 113
Проверенный на переполнение результат: 14
System.OverflowException: Arithmetic operation resulted in an overflow.
   at LearnCSharpException.CheckedBlocks.Main(String[] args) in ... :line 42

*/
