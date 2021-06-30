using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class StrRdrWrtDemo
    {
        static void Main(string[] args)
        {
            StringWriter strWtr = null;
            StringReader strRdr = null;
            string str;

            try
            {
                strWtr = new StringWriter();

                for (int i = 0; i < 10; i++)
                {
                    strWtr.WriteLine("Значение i равно: " + i);
                }

                strRdr = new StringReader(strWtr.ToString());
                
                while ((str = strRdr.ReadLine())!= null)
                {
                    Console.WriteLine(str);
                }
                
                //Console.WriteLine(strWtr.ToString());
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода\n" + exc.Message);
                throw;
            }
            finally
            {
                if (strRdr != null) strRdr.Close();
                if (strWtr != null) strWtr.Close();
            }
        }
    }
}
