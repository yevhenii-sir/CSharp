using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    static class WriteToFilePractice
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя файла: ");
            WriteToFile file = new WriteToFile(Console.ReadLine());

            object tempStr = "";
            
            Console.WriteLine("Вводите текст который нужно записать в файл. Для завершения напишите Exit.");
            while ((tempStr = Console.ReadLine())?.ToString() != "Exit")
            {
                lock (file) new Thread(file.Write).Start(tempStr);
            } 

            file.Close();
        }
    }
}


