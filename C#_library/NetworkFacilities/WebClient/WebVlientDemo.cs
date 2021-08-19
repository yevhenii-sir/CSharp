using System;
using System.Net;

namespace LearnCSharpWeb
{
    static class WebClientDemo
    {
        static void Main(string[] args)
        {
            WebClient user = new WebClient();
            string uri = "https://github.com/";

            string fname = "data.html";

            try
            {
                Console.WriteLine("Загрузка даных по адресу " + uri + " в файл " + fname);
                user.DownloadFile(uri, fname);
            }
            catch (WebException exc)
            {
                Console.WriteLine(exc.Message);
            }
            
            Console.WriteLine("Загрузка завершена.");
        }
    }
}
