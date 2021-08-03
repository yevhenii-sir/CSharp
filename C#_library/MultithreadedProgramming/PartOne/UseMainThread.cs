using System;
using System.Threading;

namespace LearnCSharpMultiThrProgramming
{
    static class UseMain
    {
        static void Main(string[] args)
        {
            Thread thrd;
            
            thrd = Thread.CurrentThread;

            if (thrd.Name == null)
                Console.WriteLine("У основного потока нет имени.");
            else Console.WriteLine("Основной поток называется " + thrd.Name);
            
            Console.WriteLine("Приоритет: " + thrd.Priority);
            Console.WriteLine();
            
            Console.WriteLine("Установка имени и приоритета.\n");
            thrd.Name = "Основной Поток";
            thrd.Priority = ThreadPriority.AboveNormal;
            
            Console.WriteLine("Теперь основной поток называется: " + thrd.Name +
                              "\nТеперь приоритет: " + thrd.Priority);
        }
    }
}


