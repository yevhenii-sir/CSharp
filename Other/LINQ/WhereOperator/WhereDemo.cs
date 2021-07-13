using System;
using System.Linq;

namespace LearnCSharpLINQ
{
    static class WhereDemo
    {
        static void Main(string[] args)
        {
            string[] strs =
            {
                ".com", ".net", "hsNameA.com",
                "hsNameB.net", "test", ".network",
                "hsNameC.net", "hsNameD.com"
            };

            var netAddrs = from addr in strs
                where addr.Length > 4 && addr.EndsWith(".net", StringComparison.Ordinal)
                select addr;

            foreach (var str in netAddrs) Console.WriteLine(str);
        }
    }
}
