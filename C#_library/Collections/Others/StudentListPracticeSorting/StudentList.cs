using System;
using System.Collections.Generic;

namespace LearnCSharpCollections
{
    static class StudentList
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                { new Student(4535, "Yevhenii", "Sirenko") },
                { new Student(1254, "Alex", "Vazovski") },
                { new Student(3452, "Tom", "Kingsman") },
                { new Student(4457, "Yalbek", "Mashkin") }
            };
            
            Console.WriteLine("Не отсортированный список студентов: ");
            Console.WriteLine(" " + String.Join("\n ", students) + '\n');

            students.Sort();
            Console.WriteLine("Отсортированный список студентов: ");
            Console.WriteLine(" " + String.Join("\n ", students));
        }
    }
}

/*

Не отсортированный список студентов: 
 №  4535 Имя: Yevhenii Фамилия:  Sirenko
 №  1254 Имя:     Alex Фамилия: Vazovski
 №  3452 Имя:      Tom Фамилия: Kingsman
 №  4457 Имя:   Yalbek Фамилия:  Mashkin

Отсортированный список студентов: 
 №  1254 Имя:     Alex Фамилия: Vazovski
 №  3452 Имя:      Tom Фамилия: Kingsman
 №  4457 Имя:   Yalbek Фамилия:  Mashkin
 №  4535 Имя: Yevhenii Фамилия:  Sirenko
 
*/
