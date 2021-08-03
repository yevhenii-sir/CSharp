using System;
using System.IO;

namespace LearnCSharpMultiThrProgramming
{
    public class WriteToFile
    {
        public string FileName { get; private set; }

        private StreamWriter _streamWriter;

        public WriteToFile(string fileName)
        {
            FileName = fileName;

            try
            {
                _streamWriter = new StreamWriter(fileName);
                Console.WriteLine("Файл для записи успешно создан.");
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка при создании файла. \n" + exc.Message);
            }
        }

        public void Write(object text)
        {
            WriteToFilePractice.Mtx.WaitOne();
            
            _streamWriter.WriteLine(text.ToString());
            
            WriteToFilePractice.Mtx.ReleaseMutex();
        }

        public void Close()
        {
            _streamWriter?.Close();
        }
    }
}
