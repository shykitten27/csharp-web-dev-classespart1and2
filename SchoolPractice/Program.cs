using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            //instatiate new students
            Student s1 = new Student("Donna Seidel", 00000027, 1, 4.0);
            Student s2 = new Student("PeeWee Herman", 00000033, 0, 0.0);
            Student s3 = new Student("Marilyn Munster", 00000013, 36, 3.85);

            List<Student> studentsList = new List<Student>();
            studentsList.Add(s1);
            studentsList.Add(s2);
            studentsList.Add(s3);

            //instatiate new teacher
            Teacher newTeacher = new Teacher("Dr.", "Evil", "World Domination", 10);

            //instatiate new course - courseNo, list of students, teacher
            Course worldDomination = new Course(101, studentsList, newTeacher);

        }
    }
}
