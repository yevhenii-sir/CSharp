using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    public class MyClass
    {
        public void MyTask()
        {
            Console.WriteLine("MyTask() запущен");

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask(), подсчет равен " + count);
            }
            
            Console.WriteLine("MyTask завершен");
        } 
    }
}
