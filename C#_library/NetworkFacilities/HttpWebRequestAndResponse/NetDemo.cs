using System;
using System.IO;
using System.Net;

namespace LearnCSharpWeb
{
    class NetDemo
    {
        static void Main(string[] args)
        {
            int ch;
            
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://www.mheducation.com/");
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            Stream istrm = resp.GetResponseStream();

            for (int i = 0; ; i++)
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
    }
}
