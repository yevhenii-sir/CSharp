using System;

namespace Exercise
{
    static class StudentDemo
    {
        static void Main(string[] args)
        {
            Student[] arrStudents = new Student[4];

            arrStudents[0] = new Student("Евгений", 5, 5, 5, 5);
            arrStudents[1] = new Aspirant("Ростислав", "Ляш", 4, 5, 2, 5);
            arrStudents[2] = new Student("Сергей", 4, 3, 2);
            arrStudents[3] = new Aspirant("Алекс", 5, 5, 5, 5, 5);

            foreach (var onePerson in arrStudents)
            {
                Console.WriteLine($"Получает степендию размером: " + onePerson.GetScholarhip() + "грн.");
                onePerson.ShowInfo();
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
