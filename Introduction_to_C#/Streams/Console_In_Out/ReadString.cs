using System;

namespace LearnCSharpStreams
{
    public static class ReadString
    {
        static void Main(string[] args)
        {
            Console.Write("Введите несколько символов: ");
            string str = Console.ReadLine();
            Console.WriteLine("Вы ввели: " + str);
            
            Console.Write("\nВведите еще несколько символов: ");
            str = Console.In.ReadLine();
            Console.WriteLine("Вы ввели: " + str);
        }
    }
}
