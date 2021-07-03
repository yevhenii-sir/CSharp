using System;
using System.IO;

namespace KeyboardSimulator
{
    public static class WordAndFileProcessing
    {
        public static void TextDataOutput(out int fullLength, out string text)
        {
            bool result;
            
            do
            {
                result = WordAndFileProcessing.OpenTextFile(out text);
            } while (result);

            fullLength = text.Length;
        }
        
        private static bool OpenTextFile(out string str)
        {
            Console.Write("Введите названия текстового файла полностю: ");
            string fileName = Console.ReadLine(); //"text.txt";

            StreamReader fstrIn = null;
            string result = "";

            try
            {
                fstrIn = new StreamReader(fileName);

                string tempStr;
                while ((tempStr = fstrIn.ReadLine()) != null)
                {
                    result += tempStr + '\n';
                }

                result = result.Substring(0, result.Length - 1);
                
                return false;
            }
            catch (IOException exc)
            {
                Console.WriteLine("Возникла ошибка: " + exc.Message);
                return true;
            }
            finally
            {
                if (fstrIn != null) fstrIn.Close();
                str = result;
            }
        }
    }
}
