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
            
            Console.Write("Введите место для просмотра текущей температуры: ");
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

                var stringTemp = Regex.Match(htmlCode, @"(?<=class=.today-temp.>)[+|-]\d*", RegexOptions.IgnoreCase);
                
                Console.WriteLine("Температура в \"" + location + "\": " + stringTemp.Value + "°С, время - " +
                                  System.DateTime.Now.ToLongTimeString() + ".");
            }
            catch
            {
                Console.WriteLine("Такого места не найдено!");
            }
        }
    }
}
