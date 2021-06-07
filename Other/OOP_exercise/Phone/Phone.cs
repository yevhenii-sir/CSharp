using System;

namespace Exercise
{
    public class Phone
    {
        private string number, model;
        private int weight;

        public Phone() : this("?", "?", 0)
        {
        }     
        
        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
        }
        
        public Phone(string number, string model, int weight) : this(number, model)
        {
            this.weight = weight;
        }

        public void Show()
        {
            Console.WriteLine($"Номер: +{number}\nМодель: {model}\nМасса: {weight}");
        }

        public void ReciveCall(string caller_name)
        {
            Console.WriteLine($"Звонит {caller_name}");
        }

        public void ReciveCall(string caller_name, string caller_number)
        {
            Console.WriteLine($"Звонит {caller_name}, номер - {caller_number}");
        }

        public void SendMessage(string msg, params string[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("Не указано телефоны!");
                return;
            };

            foreach (var i in numbers)
            {
                Console.WriteLine($"Сообщение \"{msg}\" отправлено на номер {i}");
            }
        }
        
        public string GetNumber()
        {
            return number;
        }
    }
}
