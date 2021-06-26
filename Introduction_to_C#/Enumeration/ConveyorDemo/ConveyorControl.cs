using System;

namespace BasicLearnCSharp
{
    public class ConveyorControl
    {
        public enum Action
        {
            Start,
            Stop,
            Forward,
            Reverse
        };

        public void Conveyor(Action com)
        {
            switch (com)
            {
                case Action.Start:
                    Console.WriteLine("Запустить конвейер.");
                    break;
                case Action.Stop:
                    Console.WriteLine("Остановить конвейер.");
                    break;
                case Action.Forward:
                    Console.WriteLine("Переместить конвейер вперед.");
                    break;
                case Action.Reverse:
                    Console.WriteLine("Переместить конвейер назад.");
                    break;
            }
        }
    }
}
