using System;
using System.Net;

namespace LearnCSharpWeb
{
    class CookieDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Write URL: ");
            
            HttpWebRequest wrq = (HttpWebRequest)WebRequest.Create(Console.ReadLine());
            wrq.CookieContainer = new CookieContainer();

            HttpWebResponse resp = (HttpWebResponse)wrq.GetResponse();
            
            Console.WriteLine("Количество cookie-наборов: " + resp.Cookies.Count);
            Console.WriteLine($"{"Имя", -20}Значение");
            for (int i = 0; i < resp.Cookies.Count; i++)
                Console.WriteLine($"{resp.Cookies[i].Name, -20}{resp.Cookies[i].Value}");
            
            resp.Close();
        }
    }
}

/*

Write URL: https://github.com/
Количество cookie-наборов: 3
Имя                 Значение
_gh_sess            lV%2BbQwIGP%2BDMmhMdXL...
_octo               GH1.1.815843473
logged_in           no

*/
