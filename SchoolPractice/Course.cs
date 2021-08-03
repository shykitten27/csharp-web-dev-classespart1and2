using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course //each course has a CourseNo, List of Student.cs and Teacher.cs
    {
        private int CourseNo {get; set; }
        private List<Student> Student = new List<Student>();
        private Teacher CourseTeacher { get; set; }

        //constructor
        public Course(int courseNo, List<Student> student, Teacher cTeacher)
        {
            CourseNo = courseNo;
            Student = student;
            CourseTeacher = CourseTeacher;
        }
        public override boolean Equals(object toBeCompared)
        {
            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }
        }

        public override string ToString()
        {
            return CourseNo + "/n Teacher: " + CourseTeacher + "/nStudents: " + Student;
        }
    }
}