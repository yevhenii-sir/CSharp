using System;

namespace LearnCShOther
{
    static class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Manager();
            UseEmployee(employee);
        }

        private static void UseEmployee(Employee employee)
        {
            switch (employee)
            {
                case Manager { IsOnVacation: false } manager: //case Manager manager when manager.IsOnVacation==false
                    manager.Work();
                    break;
                case null:
                    Console.WriteLine("Объект не задан");
                    break;
                default:
                    Console.WriteLine("Объект не менеджер");
                    break;
            }
        }
    }
}
