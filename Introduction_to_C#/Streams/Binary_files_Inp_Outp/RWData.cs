using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class RWData
    {
        static void Main(string[] args)
        {
            BinaryWriter dataOut;
            BinaryReader dataIn;

            int i = 10;
            double d = 1023.56;
            bool b = true;
            string str = "Это тест";

            try
            {
                dataOut = new BinaryWriter(
                    new FileStream("TestData", FileMode.Create));
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла: \n" + exc.Message);
                return;
            }

            try
            {
                Console.WriteLine("Запись " + i);
                dataOut.Write(i);

                Console.WriteLine("Запись " + d);
                dataOut.Write(d);

                Console.WriteLine("Запись " + b);
                dataOut.Write(b);

                Console.WriteLine("Запись " + 12.2 * 7.4);
                dataOut.Write(12.2 * 7.4);

                Console.WriteLine("Запись " + str);
                dataOut.Write(str);


            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally
            {
                dataOut.Close();
            }
            
            Console.WriteLine();

            try
            {
                dataIn = new BinaryReader(
                    new FileStream("TestData", FileMode.Open));
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла: \n" + exc.Message);
                return;
            }

            try
            {
                i = dataIn.ReadInt32();
                Console.WriteLine("Чтение " + i);
                
                d = dataIn.ReadDouble();
                Console.WriteLine("Чтение " + d);
                
                b = dataIn.ReadBoolean();
                Console.WriteLine("Чтение " + b);
                
                d = dataIn.ReadDouble();
                Console.WriteLine("Чтение " + d);
                
                str = dataIn.ReadString();
                Console.WriteLine("Чтение " + str);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally
            {
                dataIn.Close();
            }
        }
    }
}

