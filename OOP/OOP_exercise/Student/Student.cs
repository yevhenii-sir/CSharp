using System;

namespace Exercise
{
    public class Student
    {
        public string FirstName { get; protected set; }
        
        public string LastName { get; protected set; }
        
        public string Group { get; protected set; }

        public double AverageMark { get; protected set; }

        public int[] Marks { get; protected set; }

        public Student(string firstName, params int[] marks) : 
            this(firstName, "null", marks) {}
        
        public Student(string firstName, string lastName, params int[] marks) : 
            this(firstName, lastName, "null", marks) {}
        
        public Student(string firstName, string lastName, string group, params int[] marks)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
            Marks = marks;
            AverageMark = ComputationAverageMark(marks);
        }

        protected double ComputationAverageMark(int[] marks)
        {
            if (marks.Length == 0) return -1;
            else
            {
                double result = 0;
                foreach (var mark in marks)
                {
                   result += (double)mark;
                }

                result /= marks.Length;
                
                return result;
            }
        }

        public virtual int GetScholarhip()
        {
            if (AverageMark.Equals(5)) return 100;
            else
                return 80;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Имя и фамилия студента: {FirstName} {LastName}");
            Console.WriteLine("Група: {0}, средний бал: {1:#.##}", Group, AverageMark);
            Console.Write($"Оценки: ");
            foreach (var mark in Marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}
