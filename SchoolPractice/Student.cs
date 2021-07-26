using System;

namespace SchoolPractice
{
    public class Student
    {
        private string Name { get; set; }
        private int StudentId { get; set; }
        private int NumberOfCredits { get; set; }
        private double Gpa { get; set; }

        //constructor for x-fer students with credits and gpa
        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        //default constructor for NEW students with nothing to transfer
        public Student(string name, int studentId) : this(name, studentId, 0, 0.0) { }
    }
}