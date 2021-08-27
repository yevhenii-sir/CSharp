using System;
using System.IO;

namespace LearnCSharpOther
{
    static class AsyncMethods
    {
        static async void ReadWriteAsync(string s)
        { 
            using (StreamWriter writer = new StreamWriter("hello.txt", false))
            {
                await writer.WriteLineAsync(s);
            }

            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                string result = await reader.ReadLineAsync();
                Console.WriteLine(result);
            }
        }
        
        static void Main(string[] args)
        {
            ReadWriteAsync("Hello world! One step at a time");

            Console.WriteLine("Некоторая работа");
        }
    }
}
