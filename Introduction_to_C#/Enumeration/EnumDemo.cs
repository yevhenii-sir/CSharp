using System;

namespace BasicLearnCSharp
{
    static class EnumDemo
    {
        enum Apple { Jonathan, GoldenDel, RedDel, Winesap, Cortland, McIntosh}

        static void Main(string[] args)
        {
            string[] color =
            {
                "красный",
                "желтый",
                "красный",
                "красный",
                "красный",
                "красновато-зеленый"
            };

            Apple i;
            
            for (i = Apple.Jonathan; i <= Apple.McIntosh; i++) 
                Console.WriteLine(i + " имеет значение " + (int) i);
            
            Console.WriteLine();

            for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
                Console.WriteLine("Цвет сорта " + i + " - " + color[(int)i]);
        }
    }
}
