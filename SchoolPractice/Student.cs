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

        public static string GetGradeLevel(int numberOfCredits)
        {
            //no need to test for numeric as int passed?
            //do need to test for negative int?
            if (numberOfCredits < 0) 
            {
                Console.WriteLine("Invalid number of credits - must be positive.");
                return ""; //send back empty string
            }
             else if (numberOfCredits >= 0 && numberOfCredits <= 29)
            {
                return "Freshman";
            }
            else if (numberOfCredits > 29 && numberOfCredits <= 59)
            {
                return "Sophomore";
            }
            else if (numberOfCredits > 60 && numberOfCredits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        public double AddGrade(int coureseCredits, double courseGrade)
        {
            //add a course grade and update the gpa
            double qualityScore = courseGrade * coureseCredits;

            



            return Gpa;
        }
    }
}