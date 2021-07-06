using System;

namespace MyClasses
{
    public class AnotherClass
    {
        private string msg;

        public AnotherClass(string str)
        {
            msg = str;
        }

        public void Show()
        {
            Console.WriteLine(msg);
        }
    }
}}
