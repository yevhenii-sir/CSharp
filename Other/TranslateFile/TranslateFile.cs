using System;
using System.IO;

namespace Exercise
{
    static class TranslateFile
    {
        static void Main(string[] args)
        {
            StreamReader fstr_in = null;
            StreamWriter fstr_out = null;
            
            Console.WriteLine("(Все коды языков есть в прикрепленном файле)\n");
            
            Console.Write("Введите код языка с которого переводить: ");
            string from_leng = Console.ReadLine();
            
            Console.Write("Введите код языка на который переводить: ");
            string to_leng = Console.ReadLine();
            
            Console.Write("Имя файла который переводить: ");
            string file_name = Console.ReadLine();
            string file_result = file_name.Substring(0, file_name.IndexOf('.')) + "_result.txt";

            try
            {
                fstr_in = new StreamReader(file_name);
                fstr_out = new StreamWriter(file_result);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }

            string str, temp;
            Console.WriteLine();

            try
            {
                while ((str = fstr_in.ReadLine()) != null)
                {
                    temp = TranslateString.Translate(str, from_leng, to_leng);
                    Console.WriteLine(str + " - " + temp);
                    fstr_out.WriteLine(temp);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Console.WriteLine("======= Готово! ========");
                fstr_in.Close();
                fstr_out.Close();
            }
        }
    }
}


/* Пример роботы программы: 

(Все коды языков есть в прикрепленном файле)

Введите код языка с которого переводить: en
Введите код языка на который переводить: ru
Имя файла который переводить: Files/inp_words.txt

Hello - Привет
How are you? - Как поживаешь?
Watermelon - Арбуз
Developing - Разработка
======= Готово! ========

*/
