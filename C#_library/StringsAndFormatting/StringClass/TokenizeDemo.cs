using System;

namespace LearnCSharpOther
{
    static class TokenizeDemo
    {
        static void Main(string[] args)
        {
            string[] input =
            {
                "100 + 19",
                "100 / 3,3",
                "-3 * 9",
                "100 - 87"
            };
            char[] seps = {' '};
            
            foreach (var t in input)
            {
                string[] parts = t.Split(seps);
                Console.Write("Команда: " + t);

                Console.Write(", результат: ");
                double n = Double.Parse(parts[0]);
                double n2 = Double.Parse(parts[2]);
                
                switch (parts[1])
                {
                    case "+":
                        Console.WriteLine(n + n2);
                        break;
                    case "-":
                        Console.WriteLine(n - n2);
                        break;
                    case "*":
                        Console.WriteLine(n * n2);
                        break;
                    case "/":
                        Console.WriteLine($"{n / n2:#.#0}");
                        break;
                }
            }
        }
    }
}

/*

Команда: 100 + 19, результат: 119
Команда: 100 / 3,3, результат: 30,30
Команда: -3 * 9, результат: -27
Команда: 100 - 87, результат: 13

*/
