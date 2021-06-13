using System;

namespace BasicLearnCSharp
{
    static class SubStr
    {
        static void Main(string[] args)
        {
            string orgstr = "В С# упрощается обращение со строками.";

            string substr = orgstr.Substring(5, 20);
            
            Console.WriteLine("orgstr: " + orgstr);
            Console.WriteLine("substr: " + substr);
        }
    }
}
