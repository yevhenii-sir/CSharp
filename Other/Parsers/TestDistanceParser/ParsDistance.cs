using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace ParsDistance
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Маршрут с: ");
            string locationFrom = Console.ReadLine();
            
            Console.Write("Маршрут в: ");
            string locationTo = Console.ReadLine();
            
            string myUrl = $"https://www.avtodispetcher.ru/distance/?from={locationFrom}&to={locationTo}";

            WebClient client = new WebClient {Encoding = System.Text.Encoding.UTF8};
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
                                                   SecurityProtocolType.Tls;
            try
            {
                var htmlData = client.DownloadData(myUrl);

                string htmlCode = Encoding.UTF8.GetString(htmlData);

                var pars1 = Regex.Split(htmlCode, "totalDistance\">");
                var pars2 = Regex.Split(pars1[1], " ");

                var dist = Convert.ToInt32(pars2[0].Substring(0, pars2[0].IndexOf('<')));
                //или int dist = Convert.ToInt32(Regex.Replace(pars2[0], @"[^\d]+", ""));

                Console.WriteLine($"Дистанция с \"{locationFrom}\" в \"{locationTo}\" - {dist} км.");
            }
            catch
            {
                Console.WriteLine("Неправильный ввод!");
            }
        }
    }
}
