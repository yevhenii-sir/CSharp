using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class ShowFile
    {
        static void Main(string[] args)
        {
            int i;
            FileStream fin = null;

            if (args.Length != 1)
            {
                Console.WriteLine("Приминение: ShowFile File");
                return;
            }

            try
            {
                fin = new FileStream(args[0], FileMode.Open);

                do
                {
                    i = fin.ReadByte();
                    if (i != -1) Console.Write((char) i);
                } while (i != -1);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода: \n" + exc);
            }
            finally
            {
                if (fin != null) fin.Close();
            }
        }
    }
}
