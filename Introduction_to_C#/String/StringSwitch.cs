using System;

namespace BasicLearnCSharp
{
    static class StringSwitch
    {
        static void Main(string[] args)
        {
            string[] strs = {"один", "два", "три", "два", "один"};

            foreach (string xStr in strs)
            {
                switch (xStr)
                {
                    case "один":
                        Console.Write(1);
                        break;
                    case "два":
                        Console.Write(2);
                        break;
                    case "три":
                        Console.Write(3);
                        break;
                    
                }
            }
            Console.WriteLine();
        }
    }
}
