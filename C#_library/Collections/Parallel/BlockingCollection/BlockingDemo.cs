using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace LearnCSharpCollections
{
    static class BlockingDemo
    {
        private static BlockingCollection<char> be;

        static void Producer()
        {
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                be.Add(ch);
                Console.WriteLine("+ Производиться символ " + ch);
            }
        }

        static void Consumer()
        {
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine("- Потребляеться символ " + be.Take());
            }
        }

        static void Main(string[] args)
        {
            be = new BlockingCollection<char>(4);

            Task prod = new Task(Producer);
            Task con = new Task(Consumer);
            
            con.Start();
            prod.Start();

            try
            {
                Task.WaitAll(con, prod);
            }
            catch (AggregateException exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                con.Dispose();
                prod.Dispose();
                be.Dispose();
            }
        }
    }
}

/*
 
+ Производиться символ A
+ Производиться символ B
+ Производиться символ C
+ Производиться символ D
+ Производиться символ E
- Потребляеться символ A
- Потребляеться символ B
+ Производиться символ F
- Потребляеться символ C
+ Производиться символ G
- Потребляеться символ D
+ Производиться символ H
- Потребляеться символ E
+ Производиться символ I
- Потребляеться символ F
+ Производиться символ J
- Потребляеться символ G
+ Производиться символ K
- Потребляеться символ H
+ Производиться символ L
- Потребляеться символ I
+ Производиться символ M
- Потребляеться символ J
- Потребляеться символ K
- Потребляеться символ L
+ Производиться символ N
- Потребляеться символ M
+ Производиться символ O
- Потребляеться символ N
- Потребляеться символ O
+ Производиться символ P
- Потребляеться символ P
+ Производиться символ Q
- Потребляеться символ Q
+ Производиться символ R
- Потребляеться символ R
+ Производиться символ S
- Потребляеться символ S
+ Производиться символ T
- Потребляеться символ T
- Потребляеться символ U
+ Производиться символ U
+ Производиться символ V
- Потребляеться символ V
+ Производиться символ W
- Потребляеться символ W
+ Производиться символ X
- Потребляеться символ X
+ Производиться символ Y
- Потребляеться символ Y
+ Производиться символ Z
- Потребляеться символ Z 

*/
