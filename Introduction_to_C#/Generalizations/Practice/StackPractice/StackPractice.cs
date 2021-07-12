using System;

namespace LearnCSharp
{
    static class StackPractice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создать стек символов и вывести: ");
            Stack<char> chStack = new Stack<char>(5);

            try
            {
                for (char ch = 'a'; ch <= 'e'; ch++)
                {
                    chStack.Push(ch);
                }

                for (int i = 0; i < 6; i++)
                {
                    Console.Write(chStack.Pop() + " ");
                }
            }
            catch (StackException exc)
            {
                Console.WriteLine($"\n{exc}");
            }
            
            Console.WriteLine("Стек чисел double: ");
            Stack<double> dbStack = new Stack<double>(3);
            
            Random random = new Random();

            for (int i = 0; i < 3; i++)
                if (!dbStack.IsFull()) dbStack.Push(random.Next(1, 20) + random.NextDouble());

            for (int i = 0; i < 4; i++)
                if (!dbStack.IsEmpty()) Console.Write($"{dbStack.Pop():#.0#} ");
        }
    }
}

/*

Создать стек символов и вывести: 
e d c b a 
Стек пуст!
Стек чисел double: 
13,6 6,46 15,94

 */

