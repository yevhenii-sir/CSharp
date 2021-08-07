using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnCSharpMultiThrProgramming
{
    static class DemoParallel
    {
        static void MyMeth()
        {
            Console.WriteLine("MyMeth запущен");

            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyMeth() подсчет равен " + count);
            }

            Console.WriteLine("MyMeth() завершен");
        }
        
        static void MyMeth2()
        {
            Console.WriteLine("MyMeth2() запущен");

            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyMeth2() подсчет равен " + count);
            }

            Console.WriteLine("MyMeth2() завершен");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");
            
            Parallel.Invoke(MyMeth, MyMeth2);
            
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
