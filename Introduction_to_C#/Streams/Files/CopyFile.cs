using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class CopyFile
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Приминение: CopyFile Откуда Куда");
            }

            try
            {
                File.Copy(args[0], args[1]);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка копирования файла\n" + exc.Message);
            }
        }
    }
}
