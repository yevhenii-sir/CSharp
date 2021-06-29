using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class Redirect
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            StreamWriter fstr_out = null;

            TextWriter tmp = Console.Out;
            
            try
            {
                fstr_out = new StreamWriter("Hello.txt");

                Console.SetOut(fstr_out);
                
                Console.WriteLine("Вывод перенаправляется в файл.");
                
                for (ulong i = 0; i < 10; i++)
                {
                    Console.WriteLine(random.Next(1, 50));
                }
                
                Console.WriteLine("Конец.");
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (fstr_out != null) fstr_out.Close();
            }

            /*StreamWriter standartOutp = new StreamWriter(Console.OpenStandardOutput());
            standartOutp.AutoFlush = true;*/
            
            Console.SetOut(tmp);
            Console.WriteLine("Закрытие програмы!");
        }
    }
}

/*
 
Вывод перенаправляется в файл.
40
37
38
25
3
34
18
28
22
39
Конец.

*/
