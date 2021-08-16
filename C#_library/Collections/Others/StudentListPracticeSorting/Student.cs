using System;

namespace LearnCSharpCollections
{
    public class Student : IComparable<Student>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public long GradeBookNumber { get; private set; }

        public Student(long gradeBookNumber, string firstName, string lastName)
        {
            GradeBookNumber = gradeBookNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"№{GradeBookNumber, 6} Имя: {FirstName,8} Фамилия: {LastName,8}";
        }

        public int CompareTo(Student otherStudent)
        {
            return GradeBookNumber.CompareTo(otherStudent.GradeBookNumber);
        }
    }
}
