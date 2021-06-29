using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class KtoS
    {
        static void Main(string[] args)
        {
            //FileStream fin;
            StreamReader fstr_in = null;
            string s;

            /*try
            {
                fin = new FileStream("test.txt", FileMode.Open);
            }
            catch (IOException exc)
            {
               Console.WriteLine("Ошибка открытия файла: \n" + exc.Message);
               return;
            }

            StreamReader fstr_in = new StreamReader(fin);*/
            
            try
            {
                fstr_in = new StreamReader("test.txt");
                /*while ((s = fstr_in.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }*/
                while (!fstr_in.EndOfStream)
                {
                    s = fstr_in.ReadLine();
                    Console.WriteLine(s);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода: \n" + exc.Message);
            }
            finally
            {
                //fstr_in.Close();
                if (fstr_in != null) fstr_in.Close();
            }
        }
    }
}
