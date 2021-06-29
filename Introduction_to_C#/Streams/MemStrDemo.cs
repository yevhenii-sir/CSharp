using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class MemStrDemo
    {
        static void Main(string[] args)
        {
            byte[] storage = new byte[255];

            MemoryStream memstrm = new MemoryStream(storage);

            StreamWriter memwtr = new StreamWriter(memstrm);
            StreamReader memrdr = new StreamReader(memstrm);

            try
            {
                for (int i = 0; i < 10; i++)
                    memwtr.WriteLine("byte [" + i + "]: " + i);

                memwtr.WriteLine(".");

                memwtr.Flush();

                Console.WriteLine("Чтение прямо из масива storage: ");

                foreach (byte ch in storage)
                {
                    if ((char)ch == '.') break;
                    Console.Write((char)ch);
                }

                Console.WriteLine("\nЧтение из потока с помощю объекта memrdr: ");
                memstrm.Seek(0, SeekOrigin.Begin);

                string str = memrdr.ReadLine();
                while (str != null)
                {
                    str = memrdr.ReadLine();
                    if (str[0] == '.') break;
                    Console.WriteLine(str);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода\n" + exc.Message);
            }
            finally
            {
                memwtr.Close();
                memrdr.Close();
            }
        }
    }
}
