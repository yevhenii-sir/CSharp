using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class CopyFile
    {
        static void Main(string[] args)
        {
            int i;
            FileStream fin = null;
            FileStream fout = null;

            if (args.Length != 2)
            {
                Console.WriteLine("Применение: CopyFile Откуда Куда");
                return;
            }
            
            try
            {
                fin = new FileStream(args[0], FileMode.Open);
                fout = new FileStream(args[1], FileMode.Create);

                do
                {
                    i = fin.ReadByte();
                    if (i != -1) fout.WriteByte((byte) i);
                } while (i != -1);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода: \n" + exc.Message);
            }
            finally
            {
                if (fin != null) fin.Close();
                if (fout != null) fout.Close();
            }
        }
    }
}
