using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace LearnCSharpCollections
{
    static class BlockingDemo
    {
        private static BlockingCollection<char> bc;

        private static void Producer()
        {
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                bc.Add(ch);
                Console.WriteLine("+ Производиться символ " + ch);
            }

            bc.CompleteAdding();
        }

        private static void Consumer()
        {
            char ch;
            while (!bc.IsCompleted)
                if (bc.TryTake(out ch))
                    Console.WriteLine("- Потребляеться символ " + ch);
        }

        static void Main(string[] args)
        {
            bc = new BlockingCollection<char>(4);

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
                bc.Dispose();
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
- Потребляеться символ C
- Потребляеться символ D
- Потребляеться символ E
- Потребляеться символ F
+ Производиться символ F
+ Производиться символ G
+ Производиться символ H
- Потребляеться символ G
+ Производиться символ I
- Потребляеться символ H
+ Производиться символ J
+ Производиться символ K
+ Производиться символ L
- Потребляеться символ I
+ Производиться символ M
+ Производиться символ N
- Потребляеться символ J
- Потребляеться символ K
+ Производиться символ O
- Потребляеться символ L
+ Производиться символ P
+ Производиться символ Q
- Потребляеться символ M
- Потребляеться символ N
+ Производиться символ R
- Потребляеться символ O
+ Производиться символ S
- Потребляеться символ P
- Потребляеться символ Q
+ Производиться символ T
- Потребляеться символ R
+ Производиться символ U
- Потребляеться символ S
+ Производиться символ V
- Потребляеться символ T
+ Производиться символ W
- Потребляеться символ U
+ Производиться символ X
- Потребляеться символ V
+ Производиться символ Y
- Потребляеться символ W
+ Производиться символ Z
- Потребляеться символ X
- Потребляеться символ Y
- Потребляеться символ Z

*/
