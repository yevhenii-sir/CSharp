using System;
using System.Collections;

namespace LearnCSharpCollections
{
    static class SortedListSimplePractice
    {
        static void Main(string[] args)
        {
            SortedList studentInCollage = new SortedList();
            int key;
            
            try
            {
                Console.WriteLine("Для окончания ввода напишите -1.");
                Console.Write("Введите номер зачетной книжки студента: ");
                while ((key = Convert.ToInt32(Console.ReadLine())) != -1)
                {
                    if (studentInCollage.ContainsKey(key)) Console.WriteLine("Студент уже присутствует в колледже. Введите достоверные даные.");
                    else
                    {
                        Console.Write("Введите имя и фамилию: ");
                        studentInCollage[key] = Console.ReadLine();
                    }
                    Console.Write("Введите номер зачетной книжки студента: ");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы неправильно ввели!");
                return;
            }
            
            Console.Clear();
            
            Console.WriteLine("Зачетная книжка | Имя и фамилия");
            foreach (var student in studentInCollage.Keys)
            {
                Console.WriteLine(student + "\t" + studentInCollage[student]);
            }
        }
    }
}
