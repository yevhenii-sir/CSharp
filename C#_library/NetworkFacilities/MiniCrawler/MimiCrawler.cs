using System;
using System.IO;
using System.Net;

namespace LearnCSharpWeb
{
    static class MiniCrawler
    {
        static string FindLink(string htmlstr, ref int startloc)
        {
            int i;
            int start, end;
            string uri = null;

            i = htmlstr.IndexOf("href=\"http", startloc, StringComparison.OrdinalIgnoreCase);

            if (i != -1)
            {
                start = htmlstr.IndexOf('"', i) + 1;
                end = htmlstr.IndexOf('"', start);
                uri = htmlstr.Substring(start, end - start);
                startloc = end;
            }

            return uri;
        }
        
        static void Main(string[] args)
        {
            string link = null;
            string str, answer;

            int curloc;
            
            Console.Write("Введите URL: ");
            string uristr = Console.ReadLine();

            HttpWebResponse resp = null;
            
            try
            {
                do
                {
                    Console.WriteLine("Переход по ссылке " + uristr);
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uristr);

                    uristr = null;

                    resp = (HttpWebResponse)request.GetResponse();
                    Stream istrm = resp.GetResponseStream();
                    StreamReader rdr = new StreamReader(istrm);
                    str = rdr.ReadToEnd();

                    curloc = 0;
                    do
                    {
                        link = FindLink(str, ref curloc);

                        if (link != null)
                        {
                            Console.WriteLine("Найдена ссылка: " + link);
                            Console.Write("Перейти по ссылке, Искать дальше, Выйти?");
                            answer = Console.ReadLine();

                            if (string.Equals(answer, "П", StringComparison.OrdinalIgnoreCase))
                            {
                                uristr = link;
                                break;
                            }
                            else if (string.Equals(answer, "В", StringComparison.OrdinalIgnoreCase))
                            {
                                break;
                            }
                            else if (string.Equals(answer, "И", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Поиск следующей ссылки.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Больше ссылок не найдено");
                            break;
                        }
                    } while (link.Length > 0);

                    resp?.Close();
                } while (uristr != null);
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

/*

Введите URL: https://github.com/
Переход по ссылке https://github.com/
Найдена ссылка: https://github.githubassets.com
Перейти по ссылке, Искать дальше, Выйти?И
Поиск следующей ссылки.
Найдена ссылка: https://avatars.githubusercontent.com
Перейти по ссылке, Искать дальше, Выйти?П
Переход по ссылке https://avatars.githubusercontent.com
Найдена ссылка: https://github.githubassets.com
Перейти по ссылке, Искать дальше, Выйти?И
Поиск следующей ссылки.
Найдена ссылка: https://avatars.githubusercontent.com
Перейти по ссылке, Искать дальше, Выйти?И
Поиск следующей ссылки.
Найдена ссылка: https://github-cloud.s3.amazonaws.com
Перейти по ссылке, Искать дальше, Выйти?П
Переход по ссылке https://github-cloud.s3.amazonaws.com
Сетевая ошибка: The remote server returned an error: (403) Forbidden.
Код состояния: ProtocolError

 */

