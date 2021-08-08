using System;
using System.Linq;

namespace LearnCSharp
{
    static class WriteToFilePractice
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя файла: ");
            WriteToFile writeToFile = new WriteToFile(Console.ReadLine());
            
            writeToFile.WriteTestLines((n) => n % 5 == 0, 0, 500); //записать в файл числа кратные 5 от 0 до 100
            writeToFile.WriteText("-----------------------------");
            writeToFile.WriteTestLines((n) => n.ToString() == String.Join("", n.ToString().Reverse()), 10, 10000); //найти числа которые одинаковые при реверсе

            writeToFile.Close();
        }
    }
}
