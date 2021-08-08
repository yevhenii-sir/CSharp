using System;
using System.IO;

namespace LearnCSharp
{
    public class WriteToFile
    {
        private StreamWriter _streamWriter;
        public string FileName { get; private set; }

        public WriteToFile(string fileName)
        {
            FileName = fileName;

            try
            {
                _streamWriter = new StreamWriter(FileName);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла!\n" + exc.Message);
            }
        }

        public void WriteTestLines(Func<int, bool> func, int from, int to)
        {
            try
            {
                for (int i = from; i < to; i++)
                    if (func(i)) _streamWriter.WriteLine(i);

                Console.WriteLine("Записно в файл!");
            }
            catch (IOException)
            {
                Console.WriteLine("Проблемы с файлом!");
                throw;
            }
        }

        public void WriteText(string text)
        {
            try
            {
                _streamWriter.WriteLine(text);
            }
            catch (IOException)
            {
                Console.WriteLine("Проблемы с файлом!");
                throw;
            }
        }

        public void Close() => _streamWriter?.Close();
    }
}
