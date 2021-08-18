using System;
using System.Net;

namespace LearnCSharpWeb
{
    class HeaderDemo
    {
        static void Main(string[] args)
        {
            WebResponse resp = WebRequest.Create("https://github.com/").GetResponse();
            
            string[] names = resp.Headers.AllKeys;
            
            Console.WriteLine($"{"Имя", -20}Значение\n");
            foreach (var name in names)
            {
                Console.Write($"{name, -20}");
                foreach (var v in resp.Headers.GetValues(name))
                {
                    Console.WriteLine(v);
                }
            }
            
            resp.Close();
        }
    }
}

/*

Имя                 Значение

Server              GitHub.com
Date                Wed, 18 Aug 2021 19:50:22 GMT
Vary                X-PJAX
...

*/
