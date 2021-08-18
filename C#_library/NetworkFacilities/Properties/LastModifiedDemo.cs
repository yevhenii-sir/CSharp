using System;
using System.Net;

namespace LearnCSharpWeb
{
    class LastModifiedDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Write URL: ");

            HttpWebResponse resp = (HttpWebResponse)WebRequest.Create(Console.ReadLine()).GetResponse();
            Console.WriteLine("Последняя модификация: " + resp.LastModified);
            
            resp.Close();
        }
    }
}

/*

Write URL: https://github.com/
Последняя модификация: 8/19/2021 12:57:18 AM

*/
