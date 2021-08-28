using System;
using System.IO;

namespace LearnCSharpOther
{
    static class Program
    {
        static void Main(string[] args)
        {
            string dirName = Directory.GetCurrentDirectory();

            DirectoryInfo directoryInfo = new DirectoryInfo(dirName);
            
            Console.WriteLine("Название каталога: " + directoryInfo.Name);
            Console.WriteLine("Полное название каталога: " + directoryInfo.FullName);
            Console.WriteLine("Время создания каталога: " + directoryInfo.CreationTime);
            Console.WriteLine("Кореневой каталог: " + directoryInfo.Root);
        }
    }
}
