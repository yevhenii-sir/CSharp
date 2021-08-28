using System;
using System.IO;

namespace LearnCSharpOther
{
    static class Program
    {
        static void ShowDirectories(string dirName)
        {
            Console.WriteLine("Подкаталоги: ");
            string[] dirs = Directory.GetDirectories(dirName);
            foreach (var dir in dirs)
            {
                Console.WriteLine(dir);
            }
        }

        static void ShowFiles(string dirName)
        {
            Console.WriteLine("Файлы: ");
            string[] files = Directory.GetFiles(dirName);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
        
        static void Main(string[] args)
        {
            string dirName = Directory.GetCurrentDirectory();

            if (Directory.Exists(dirName))
            {
                ShowDirectories(dirName);
                Console.WriteLine();
                ShowFiles(dirName);
                Console.WriteLine();
                Console.WriteLine("Создадим папку Collections. ");
                dirName += "/MyPath";
                string subpath = "Collections";
                DirectoryInfo directoryInfo = new DirectoryInfo(dirName);
                if (!directoryInfo.Exists)
                {
                    directoryInfo.Create();
                }

                directoryInfo.CreateSubdirectory(subpath);
                Console.WriteLine();
                ShowDirectories(dirName);
            }
        }
    }
}
