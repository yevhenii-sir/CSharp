using System;
using System.Collections.Generic;
using System.Xml;

namespace LearnCSharpOther
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
    
    static class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                User user = new User();
                XmlNode attr = xnode.Attributes.GetNamedItem("name");
                if (attr != null)
                    user.Name = attr.Value;

                foreach (XmlNode childNode in xnode.ChildNodes)
                {
                    if (childNode.Name == "company")
                        user.Company = childNode.InnerText;
                    
                    if (childNode.Name == "age")
                        user.Age = Int32.Parse(childNode.InnerText);
                }
                users.Add(user);
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} ({user.Company}) - {user.Age}");
            }
        }
    }
}

/*

Bill Gates (Microsoft) - 48
Larry Page (Google) - 42

*/
