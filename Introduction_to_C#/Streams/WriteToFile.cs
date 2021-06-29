using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class WriteToFile
    {
        static void Main(string[] args)
        {
            FileStream fout = null;

            try
            {
                fout = new FileStream("testim.txt", FileMode.CreateNew);

                string str = Console.ReadLine();

                foreach (var s in str)
                {
                    fout.WriteByte((byte) s);
                }

                fout.WriteByte((byte) '\n');
                
                for (char c = 'A'; c < 'Z'; c++)
                {
                    fout.WriteByte((byte) c);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода: \n" + exc.Message);
            }
            finally
            {
                if (fout != null) fout.Close();
            }
        }
    }
}
