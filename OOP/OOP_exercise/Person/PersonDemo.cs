using System;

namespace Exercise
{
    static class PersonDemo
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Sirenko Yevhenii", 17);
            
            p1.Move();
            
            p2.Talk();
            
            Console.WriteLine();
        }
    }
}
