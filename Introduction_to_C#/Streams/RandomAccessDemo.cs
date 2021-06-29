using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class RandomAccessDemo
    {
        static void Main(string[] args)
        {
            FileStream f = null;
            char ch;

            try
            {
                f = new FileStream("random.dat", FileMode.Create);

                for (int i = 0; i < 26; i++)
                {
                    f.WriteByte((byte) ('A' + i));
                }

                f.Seek(0, SeekOrigin.Begin);
                ch = (char) f.ReadByte();
                Console.WriteLine("Превая буква: " + ch);

                f.Seek(1, SeekOrigin.Begin);
                ch = (char) f.ReadByte();
                Console.WriteLine("Вторая буква: " + ch);

                f.Seek(4, SeekOrigin.Begin);
                ch = (char) f.ReadByte();
                Console.WriteLine("Пятая буква: " + ch);

                Console.WriteLine();
                
                Console.WriteLine("Буквы алфавита через одну с помощю Seek: ");
                for (int i = 0; i < 26; i += 2)
                {
                    f.Seek(i, SeekOrigin.Begin);
                    ch = (char) f.ReadByte();
                    Console.Write(ch + " ");
                }
                
                Console.WriteLine("\nБуквы алфавита через одну с помощю Position: ");
                for (int i = 0; i < 26; i += 2)
                {
                    f.Position = i;
                    ch = (char) f.ReadByte();
                    Console.Write(ch + " ");
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода\n" + exc);
            }
            finally
            {
                if (f != null) f.Close();
            }
            
            Console.WriteLine();
        }
    }
}

