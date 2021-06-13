using System;

namespace Exercise
{
    static class PhoneDemo
    {
        static void Main(string[] args)
        {
            Phone ph1 = new Phone();
            Phone ph2 = new Phone("380985245698", "Samsung");
            Phone ph3 = new Phone("380686345715", "Nokia", 1488);
            
            Console.WriteLine("Телефон ph2: ");
            ph2.Show();
            
            Console.WriteLine("\nТелефон ph3: ");
            ph3.Show();
            
            Console.WriteLine();
            
            ph1.ReciveCall("Yevhenii");
            ph1.ReciveCall("Rostik", "+380687845214");
            
            Console.WriteLine();
            
            ph1.SendMessage("Hello_World", "+380686037157", "+380987546324", "+380451575486");
            
            Console.WriteLine();
            
            Console.WriteLine("ph2 number: " + ph2.GetNumber());
        }
    }
}
