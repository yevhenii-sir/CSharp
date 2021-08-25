using System;

namespace LearnCShOther
{
    public class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Отлично, работаем дальше");
        }
        
        public bool IsOnVacation { get; set; }
    }
}
