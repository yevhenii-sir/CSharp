using System;

namespace LearnCSharpWeb
{
    class UriDemo
    {
        static void Main(string[] args)
        {
            Uri sample = new Uri("http://HerbSchildt.com/somefile.txt?SomeQuery");

            Console.WriteLine("Хост: " + sample.Host);
            Console.WriteLine("Порт: " + sample.Port);
            Console.WriteLine("Протокол: " + sample.Scheme);
            Console.WriteLine("Локальный путь: " + sample.LocalPath);
            Console.WriteLine("Запрос: " + sample.Query);
            Console.WriteLine("Путь и запрос: " + sample.PathAndQuery);
        }
    }
}
