using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class ExistsDemo
    {
        static void Main(string[] args)
        {
            string file_name = "test.txt";
            
            Console.WriteLine("Сейчас " + DateTime.Now);

            if (File.Exists(file_name))
            {
                Console.WriteLine("\nФайл существует. В последний раз он был доступен " +
                                  File.GetLastAccessTime(file_name));
            }
            else 
                Console.WriteLine("Файл не существует");
        }
    }
}

/*

Сейчас 30.06.2021 10:49:40

Файл существует. В последний раз он был доступен 29.06.2021 17:03:26

*/
