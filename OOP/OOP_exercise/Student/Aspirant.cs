using System;

namespace Exercise
{
    public class Aspirant : Student
    {
        public int ScientificWork { get; private set; }

        public Aspirant(string firstName, int sciW, params int[] marks) : 
            this(firstName, "null", sciW, marks) {}
        
        public Aspirant(string firstName, string lastName, int sciW, params int[] marks) : 
            this(firstName, lastName, "null", sciW, marks){}
        
        public Aspirant(string firstName, string lastName, string group, int sciW, params int[] marks) :
            base(firstName, lastName, group, marks)
        {
            ScientificWork = sciW;
            AverageMark = (ComputationAverageMark(marks) + ScientificWork) / 2;
        }
        public override int GetScholarhip()
        {
            if (AverageMark.Equals(5)) return 200;
            else
                return 180;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Имя и фамилия аспирата: {FirstName} {LastName}");
            Console.WriteLine("Група: {0}, средний бал: {1:#.##}", Group, AverageMark);
            Console.WriteLine("Бал за научную роботу: {0: #.##}", ScientificWork);
            Console.Write($"Оценки: ");
            foreach (var mark in Marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}
