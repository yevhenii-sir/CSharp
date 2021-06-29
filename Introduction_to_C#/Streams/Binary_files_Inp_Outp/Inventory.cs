using System;
using System.IO;

namespace LearnCSharpStreams
{
    public static class Inventory
    {
        static void Main(string[] args)
        {
            BinaryWriter dataOut;
            BinaryReader dataIn;

            string item;
            int onhand;
            double cost;

            try
            {
                dataOut = new BinaryWriter(new
                    FileStream("invertory.dat", FileMode.Create));
            }
            catch (IOException exc)
            {
                Console.WriteLine("Не удаеться открыть файл " + 
                                  "товарных запасов для вывода");
                Console.WriteLine("Причина: " + exc.Message);
                return;
            }

            try
            {
                dataOut.Write("Молотки");
                dataOut.Write(10);
                dataOut.Write(3.95);

                dataOut.Write("Отвертки");
                dataOut.Write(18);
                dataOut.Write(1.50);

                dataOut.Write("Плоскогубцы");
                dataOut.Write(5);
                dataOut.Write(4.95);

                dataOut.Write("Пилы");
                dataOut.Write(8);
                dataOut.Write(8.95);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка записи в файл товарных запасов");
                Console.WriteLine("Причина: " + exc.Message);
            }
            finally
            {
                dataOut.Close();
            }
            
            Console.WriteLine();

            try
            {
                dataIn = new BinaryReader(new
                    FileStream("invertory.dat", FileMode.Open));
            }
            catch (IOException exc)
            {
                Console.WriteLine("Не удаеться открыть файл " + 
                                  "товарных запасов для ввода");
                Console.WriteLine("Причина: " + exc.Message);
                return;
            }
            
            Console.Write("Введите наименование для поиска: ");
            string what = Console.ReadLine();
            Console.WriteLine();

            try
            {
                for (;;)
                {
                    item = dataIn.ReadString();
                    onhand = dataIn.ReadInt32();
                    cost = dataIn.ReadDouble();

                    if (item.Equals(what, StringComparison.Ordinal))
                    {
                        Console.WriteLine(item + ": " + onhand + $" штук в наличии. Цена: ${cost:#.00}" +
                                          $" за штуку. \nОбщая стоимость по наименованию <{item}>: " +
                                          $"${onhand * cost:#.00}");

                        break;
                    }
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine();
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка чтения из файла товарных запасов");
                Console.WriteLine("Причина: " + exc.Message);
            }
            finally
            {
                dataIn.Close();
            }
        }
    }
}

