using System;

namespace Basic_Learn_Csharp
{
    class Jagged
    {
        static void Main()
        {
            int[][] network_nodes = new int[4][];
            network_nodes[0] = new int[3];
            network_nodes[1] = new int[7];
            network_nodes[2] = new int[2];
            network_nodes[3] = new int[5];

            int i, j;

            for (i = 0; i < network_nodes.Length; i++)
                for (j = 0; j < network_nodes[i].Length; j++)
                {
                    network_nodes[i][j] = i * j + 70;
                }

            for (i = 0; i < network_nodes.Length; i++)
            {
                for (j = 0; j < network_nodes[i].Length; j++)
                {
                    Console.WriteLine("Использование в узле сети " + i + " ЦП " + j + ": " +
                        network_nodes[i][j] + "%");

                }
                Console.WriteLine();
            }
        }
    }
}