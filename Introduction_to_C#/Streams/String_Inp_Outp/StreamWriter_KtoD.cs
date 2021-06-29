using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class KtoD
    {
        static void Main(string[] args)
        {
            //FileStream fout = null;
            StreamWriter fstr_out = null;
            string str;

            /*try
            {
                fout = new FileStream("test.txt", FileMode.Create);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла: \n" + exc.Message);
                return;
            }*/

            //StreamWriter fstr_out = new StreamWriter(fout);
            
            try
            {
                fstr_out = new StreamWriter("test.txt");
                
                Console.WriteLine("Введите текст, а по окончании - \"стоп\".");
                do
                {
                    Console.Write(": ");
                    str = Console.ReadLine();

                    if (str != "стоп")
                    {
                        str = str + "\r\n";
                        fstr_out.Write(str);
                    }
                } while (str != "стоп");

            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода: \n" + exc.Message);
            }
            finally
            {
                //fstr_out.Close();
                if (fstr_out != null) fstr_out.Close();
            }
        }
    }
}
