using System;
using System.IO;
using System.Net;

namespace LearnCSharpWeb
{
    class NetExcDemo
    {
        static void Main(string[] args)
        {
            int ch;

            try
            {
                WebRequest req = WebRequest.Create("https://www.mheducation.com"); //https://www.mheducation.com/moonrocket - protocolError (404) Not Found
                WebResponse resp = req.GetResponse();

                Stream istrm = resp.GetResponseStream();

                for (int i = 0;; i++)
                {
                    ch = istrm.ReadByte();
                    if (ch == -1) break;
                    Console.Write((char)ch);

                    if ((i % 400) == 0)
                    {
                        Console.Write("\nНажмите клавишу <Enter>.");
                        Console.ReadLine();
                    }
                }

                resp.Close();
            }
            catch (WebException exc)
            {
                Console.WriteLine("Сетевая ошибка: " + exc.Message +
                                  "\nКод состояния: " + exc.Status);
            }
            catch (ProtocolViolationException exc)
            {
                Console.WriteLine("Протокольная ошибка: " + exc.Message);
            }
            catch (UriFormatException exc)
            {
                Console.WriteLine("Ошибка формата URI: " + exc.Message);
            }
            catch (NotSupportedException exc)
            {
                Console.WriteLine("Неизвестный протокол: " + exc.Message);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода вывода: " + exc.Message);
            }
            catch (System.Security.SecurityException exc)
            {
                Console.WriteLine("Исключение в связи с нарушением безопасности: " + exc.Message);
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine("Недопустимая операция: " + exc.Message);
            }
        }
    }
}
