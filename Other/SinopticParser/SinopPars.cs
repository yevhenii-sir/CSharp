//using example "https://upread.ru/art.php?id=84"

using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace ParsTest
{
    static class Program
    {
        static void Main(string[] args)
        {
            string myUrl = "https://sinoptik.ua/%D0%BF%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0-"; 
            string location = Console.ReadLine();
            myUrl += location;

            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
                                                   SecurityProtocolType.Tls;
            try
            {
                var htmlData = client.DownloadData(myUrl);

                string htmlCode = Encoding.UTF8.GetString(htmlData);

                var pars1 = Regex.Split(htmlCode, "class=\"today-temp\">");
                var pars2 = Regex.Split(pars1[1], " ");

                var temp = Convert.ToInt32(pars2[0].Substring(0, pars2[0].IndexOf('&')));
                //или int temp = Convert.ToInt32(Regex.Replace(pars2[0], @"[^\d]+", ""));

                Console.WriteLine("Температура в \"" + location + "\": " + temp + ", время - " +
                                  System.DateTime.Now.ToLongTimeString() + ".");
            }
            catch
            {
                Console.WriteLine("Такого места не найдено!");
            }
        }
    }
}
